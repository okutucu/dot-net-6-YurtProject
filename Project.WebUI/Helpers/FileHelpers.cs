using Project.Core.DTOs;
using Project.Service.Utilities.Extensions;
using Project.WebUI.Helpers.Abstract;

namespace Project.WebUI.Helpers
{
	public class FileHelpers : IFileHelpers
	{
		private readonly IWebHostEnvironment _env;

		public FileHelpers(IWebHostEnvironment env)
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

        public async Task<string> FileRenameAsync(string fileName)
        {
            DateTime dateTime = DateTime.Now;
            string fullPath = $"{fileName}_{dateTime.FullDateAndtimeStringWithUnderscore()}{Path.GetExtension(fileName)}";

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
                string fileNewName = await FileRenameAsync(file.FileName);
                bool result = await CopyFileAsync($"{uploadPath}\\{fileNewName}",file);
                datas.Add((fileNewName,$"{uploadPath}\\{fileNewName}"));
                results.Add(result);
            }

            if (results.TrueForAll(r => r.Equals(true)))
                return datas;

            // todo exceptionsss
            return null;
        }
	}
}
