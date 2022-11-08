using Project.Core.Enums;

namespace Project.Core.DTOs
{
	public class IncomeDetailDto : PaymentIncomeDto
    {
        public PaymentName PaymentName { get; set; }

    }
}
