using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class RoomTypeDto : BaseDto
    {
        public string RoomName { get; set; }
        public decimal IncreasedPrice { get; set; }
        public decimal Price { get; set; }
    }
}
