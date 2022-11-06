namespace Project.Core.DTOs
{
	public class RoomDto : BaseDto
	{
		public string RoomName { get; set; }
		public int Capacity { get; set; }
		public int CurrentCapacity { get; set; }
		public decimal Debt { get; set; }
		public bool Lack { get; set; }
		public string LackDetail { get; set; }
        public bool Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public int? RoomTypeId { get; set; }

	}
}
