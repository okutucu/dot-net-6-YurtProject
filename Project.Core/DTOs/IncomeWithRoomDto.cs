using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class IncomeWithRoomDto : IncomeDetailDto
    {
        public RoomDto Room { get; set; }
    }
}
