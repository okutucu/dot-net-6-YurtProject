namespace Project.Core.DTOs
{
	public class RoomTypeWithRoomDto : RoomDto
	{
		public RoomTypeDto RoomType { get; set; }
        public List<CustomerDto> Customers { get; set; }

    }
}
