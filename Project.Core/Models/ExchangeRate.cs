using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ExchangeRate : BaseEntity
    {
        public string ExchangeName { get; set; }
        public double Price { get; set; }
    }
}
