using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Project.Core.Services;
using Project.Service.Utilities.Extensions;

namespace Project.Service.Services
{
    public class FileService : IFileService
    {

        private readonly IWebHostEnvironment _env;

        public FileService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> FileRenameAsync(string fileName, string name)
        {
            DateTime dateTime = DateTime.Now;
            string fullPath = $"{name}_{dateTime.FullDateAndtimeStringWithUnderscore()}{Path.GetExtension(fileName)}";

            return fullPath;
        }

        public async Task<List<(string fileNames, string path)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_env.WebRootPath, path);
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            List<(string fileNames, string path)> datas = new();
            List<bool> results = new();


            foreach (IFormFile file in files)
            {
                string fileNewName = await FileRenameAsync(file.FileName, Path.GetFileNameWithoutExtension(file.FileName));
                bool result = await CopyFileAsync($"{uploadPath}\\{fileNewName}", file);
                datas.Add((fileNewName, $"{path}\\{fileNewName}"));
                results.Add(result);
            }

            if (results.TrueForAll(r => r.Equals(true)))
                return datas;

            // todo exceptionsss
            return null;
        }
    }
}
