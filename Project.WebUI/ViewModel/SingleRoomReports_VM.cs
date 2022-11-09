using Project.Core.DTOs;

namespace Project.WebUI.ViewModel
{
    public class SingleRoomReports_VM
    {
        public List<IncomeWithRoomDto> IncomeWithRoomDtos { get; set; }
        public List<PaymentDetailWithRoomDto> PaymentDetailWithRoomDtos { get; set; }
        public List<RoomIncomeWithRoomDto> RoomIncomeWithRoomDtos { get; set; }

    }
}
