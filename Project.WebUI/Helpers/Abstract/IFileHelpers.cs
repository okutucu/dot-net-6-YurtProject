using Project.Core.DTOs;

namespace Project.WebUI.Helpers.Abstract
{
	public interface IFileHelpers
	{
		Task<List<(string fileNames , string path)>> UploadAsync(string path, IFormFileCollection files);
		Task<bool> CopyFileAsync(string path, IFormFile file);
		Task<string> FileRenameAsync(string fileName);
	}
}
