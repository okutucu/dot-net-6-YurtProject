using Project.Core.Enums;

namespace Project.Core.Models
{
    public class IncomeDetail : BaseEntity
    {
        public string RoomName { get; set; }
        public PaymentName PaymentName { get; set; }
        public decimal Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public Exchange Exchange { get; set; }
        public decimal MoneyOfTheDay { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Description { get; set; }
    }
}
