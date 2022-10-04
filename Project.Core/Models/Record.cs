using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Record : BaseEntity
    {
        public string RoomName { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNo { get; set; }
        public string Phone { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime Depart { get; set; }
    }
}
