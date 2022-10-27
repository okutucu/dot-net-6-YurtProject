using Project.Core.Enums;

namespace Project.Core.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        // Relatipnal Property
        public virtual AppUserDetail AppUserDetail { get; set;}

    }
}
