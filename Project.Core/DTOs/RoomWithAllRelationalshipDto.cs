using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class RoomWithAllRelationalshipDto : RoomDto
    {
        public List<RoomIncomeDto> RoomIncomes { get; set; }
        public List<IncomeDetailDto> IncomeDetails { get; set; }
        public List<PaymentDetailDto> PaymentDetails { get; set; }
    }
}
