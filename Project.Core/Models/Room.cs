namespace Project.Core.Models
{
	public class Room : BaseEntity
	{
		public string RoomName { get; set; }
		public int Capacity { get; set; }
		public int CurrentCapacity { get; set; }
		public decimal Debt { get; set; }
		public bool Lack { get; set; }
		public string LackDetail { get; set; }
        public int? RoomTypeId { get; set; }

		// Relational Properties
		public IList<Customer> Customers { get; set; }
		public IList<RoomIncome> RoomIncomes { get; set; }
		public IList<IncomeDetail> IncomeDetails { get; set; }
		public IList<PaymentDetail> PaymentDetails { get; set; }
		public virtual RoomType RoomType { get; set; }

	}
}
