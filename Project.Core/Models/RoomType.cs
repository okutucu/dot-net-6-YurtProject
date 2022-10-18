using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class RoomType : BaseEntity
    {
        public string RoomName { get; set; }
        public decimal IncreasedPrice { get; set; }
        public decimal Price { get; set; }


        //Relational Properties

        public IList<Room> Rooms { get; set; }

    }
}
