using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class RoomDto : BaseDto
    {
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public decimal Price { get; set; }
        public decimal Debt { get; set; }
        public string RoomType { get; set; }
        public bool Lack { get; set; }
        public string LackDetail { get; set; }
    }
}
