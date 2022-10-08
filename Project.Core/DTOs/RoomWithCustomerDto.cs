namespace Project.Core.DTOs
{
    public class RoomWithCustomerDto  : RoomDto
    {
        public List<CustomerDto> Customers { get; set; }
   
    }
}
