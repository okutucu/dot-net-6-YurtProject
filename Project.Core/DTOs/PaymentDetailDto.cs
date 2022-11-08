using Project.Core.Enums;

namespace Project.Core.DTOs
{
	public class PaymentDetailDto : PaymentIncomeDto
    {
        public PaymentName PaymentName { get; set; }

    }
}
