using Project.Core.Enums;

namespace Project.Core.Models
{
    public class PaymentDetail : BaseEntity
    {
        public PaymentName PaymentName { get; set; }
        public decimal Price { get; set; }
        public Exchange Exchange { get; set; }
        public string CurrencyName { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal MoneyOfTheDay { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Description { get; set; }
    }
}
