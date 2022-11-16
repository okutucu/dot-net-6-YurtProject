using Project.Core.DTOs;

namespace Project.WebUI.ViewModel
{
    public class RoomDetail_VM
    {
        public RoomWithCustomerDto roomWithCustomer { get; set; }
        public List<RoomWithImageDto> roomWithImages { get; set; }

    }
}
