using Project.Core.Enums;

namespace Project.Core.Models
{
	public class IncomeDetail : PaymentIncome
    {
        public PaymentName PaymentName { get; set; }
        public int? RoomId { get; set; }

		// Relational Properties
		public virtual Room Room { get; set; }
	}
}
