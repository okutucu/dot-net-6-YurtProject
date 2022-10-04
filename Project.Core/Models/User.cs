using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class User : BaseEntity
    {
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Identity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
