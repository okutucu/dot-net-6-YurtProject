using Project.Core.DTOs;

namespace Project.WebUI.Helpers.Abstract
{
	public interface IImageHelper
	{
		Task<UploadedImageDto> UploadImage(string fileName, IFormFile pictureFile, string folderName);
	}
}
