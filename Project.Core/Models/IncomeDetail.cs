using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class IncomeDetail : BaseEntity
    {
        public string RoomName { get; set; }
        public string IncomeName { get; set; }
        public double Price { get; set; }
        public string Exchange { get; set; }
        public double MoneyOfTheDay { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
    }
}
