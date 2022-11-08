using Project.Core.Enums;

namespace Project.Core.Models
{
	public class RoomIncome : PaymentIncome
    {
	
		public int RoomId { get; set; }

		// Relational Properties
		public virtual Room Room { get; set; }

	}
}
