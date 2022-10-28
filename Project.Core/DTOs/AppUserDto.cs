using Project.Core.Enums;

namespace Project.Core.DTOs
{
	public class AppUserDto : BaseDto
	{
		public string UserName { get; set; }
		public string Password { get; set; }
        public Role Role { get; set; }

    }
}
