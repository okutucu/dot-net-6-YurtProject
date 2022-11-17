using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Core.Enums;

namespace Project.Core.Models
{
	public class IncomeDetail : PaymentIncome
    {
        public PaymentName PaymentName { get; set; }



        public int? RoomId { get; set; }



		// Relational Properties
		public virtual Room Room { get; set; }
        public IList<Image> Images { get; set; } = new List<Image>();
    }
}
