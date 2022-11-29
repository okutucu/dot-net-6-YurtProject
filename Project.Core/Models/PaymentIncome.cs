using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Project.Core.Enums;

namespace Project.Core.Models
{
    public abstract class PaymentIncome : BaseEntity
    {
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public Exchange Exchange { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal MoneyOfTheDay { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public IFormFile[] Files { get; set; }

      


    }
}
