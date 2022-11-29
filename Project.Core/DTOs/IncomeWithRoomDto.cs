namespace Project.Core.DTOs
{
	public class IncomeWithRoomDto : IncomeDetailDto
	{
		public PaymentNameDto PaymentName { get; set; }
		public RoomDto Room { get; set; }
	}
}
