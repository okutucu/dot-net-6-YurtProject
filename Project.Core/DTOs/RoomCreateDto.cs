using Microsoft.AspNetCore.Http;

namespace Project.Core.DTOs
{
	public class RoomCreateDto
	{
		public string RoomName { get; set; }
		public int Capacity { get; set; }
		public int CurrentCapacity { get; set; }
		public bool Lack { get; set; }
		public string LackDetail { get; set; }
        public IFormFile File { get; set; }
        public string FileName { get; set; }

        public DateTime CreatedDate { get; set; }
		public int RoomTypeId { get; set; }

	}
}
