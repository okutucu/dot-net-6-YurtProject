using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;

namespace Project.Core.DTOs
{
    public class RoomWithImageDto : RoomDto
    {
        public List<Image> Images { get; set; }

    }
}
