namespace Project.Core.Models
{
    public class PaymentDetail : BaseEntity
    {
        public string PaymentName { get; set; }
        public decimal Price { get; set; }
        public string Exchange { get; set; }
        public double MoneyOfTheDay { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
    }
}
