namespace Project.Core.Models
{
	public class AppUserDetail : BaseEntity
	{
		public string FullName { get; set; }
		public string Identity { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Description { get; set; }
		public int AppUserId { get; set; }

		// Relatipnal Property
		public AppUser AppUser { get; set; }
	}
}
