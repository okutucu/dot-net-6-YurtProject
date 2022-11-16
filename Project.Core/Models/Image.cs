using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
	public class Image : BaseEntity
	{
		public string FileName { get; set; }
        public int RoomId { get; set; }
        public int? CustomerId { get; set; }


        // Relational Properties
        public Room Room { get; set; }
        public Customer Customer { get; set; }



	}
}
