using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class PaymentName : BaseEntity
    {
        public string Name { get; set; }

        public IList<IncomeDetail> IncomeDetails { get; set; }
        public IList<PaymentDetail> PaymentDetails { get; set; }

    }
}
