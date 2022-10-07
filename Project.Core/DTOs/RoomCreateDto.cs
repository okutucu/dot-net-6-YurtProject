using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class RoomCreateDto : BaseDto
    {
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string RoomType { get; set; }
        public bool Lack { get; set; }
        public string LackDetail { get; set; }
    }
}
