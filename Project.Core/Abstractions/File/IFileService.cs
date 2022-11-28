using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Project.Core.Abstractions.File
{
    public interface IFileService
    {
        Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files);
        Task DeleteAsync(string path, string fileName);
        Task<bool> CopyFileAsync(string path, IFormFile file);
        Task<string> FileRenameAsync(string fileName, string name);
    }
}
