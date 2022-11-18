using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
	public class Image : BaseEntity
	{
		public string FileName { get; set; }
        public int? RoomIncomeId { get; set; }
        public int? IncomeDetailId { get; set; }
        public int? PaymentDetailId { get; set; }
        public int? CustomerId { get; set; }


        // Relational Properties
        public RoomIncome RoomIncome { get; set; }
        public IncomeDetail IncomeDetail { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public Customer Customer { get; set; }



	}
}
