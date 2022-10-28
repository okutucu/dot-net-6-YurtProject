namespace Project.Core.Models
{
	public class ExchangeRate : BaseEntity
	{
		public string ExchangeName { get; set; }
		public decimal Price { get; set; }
	}
}
