using Microsoft.AspNetCore.Http;

namespace Project.Core.Services
{
    public interface IFileService
    {
        Task<List<(string fileNames, string path)>> UploadAsync(string path, IFormFileCollection files);
        Task<bool> CopyFileAsync(string path, IFormFile file);
        Task<string> FileRenameAsync(string fileName, string name);
    }
}
