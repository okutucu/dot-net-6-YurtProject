using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Core.Enums;

namespace Project.Core.Models
{
	public class PaymentDetail : PaymentIncome
    {
        public int? RoomId { get; set; }
        public int? PaymentNameId { get; set; }

        // Relational Properties
        public virtual Room Room { get; set; }
        public PaymentName PaymentName { get; set; }

    }
}
