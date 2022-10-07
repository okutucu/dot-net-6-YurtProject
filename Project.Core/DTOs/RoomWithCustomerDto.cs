namespace Project.Core.DTOs
{
    public class RoomWithCustomerDto : RoomDto
    {
        public CustomerDto Customer { get; set; }
    }
}
