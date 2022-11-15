using Project.Core.DTOs;
using Project.WebUI.Helpers.Abstract;

namespace Project.WebUI.Helpers
{
	public class ImageHelper : IImageHelper
	{
		private readonly IWebHostEnvironment _env;

		public ImageHelper(IWebHostEnvironment env)
		{
			_env = env;
		}

		public Task<UploadedImageDto> UploadImage(string fileName, IFormFile pictureFile, string folderName)
		{
			throw new NotImplementedException();
		}

		//public Task<UploadedImageDto> UploadImage(string oldFileName, IFormFile pictureFile, string folderName)
		//{
		//	string wwwroot = _env.WebRootPath;

		//	string fileExtension = Path.GetExtension(pictureFile.FileName);

		//	DateTime dateTime = DateTime.Now;

		//	//string fileName = $"{oldFileName}_{dateTime.FullDateAndTimeStringWithIndersco}";

		//}
	}
}
