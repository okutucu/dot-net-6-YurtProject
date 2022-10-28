namespace Project.Core.DTOs
{
	public class ExchangeRateDto : BaseDto
	{
		public string ExchangeName { get; set; }
		public decimal Price { get; set; }
	}
}
