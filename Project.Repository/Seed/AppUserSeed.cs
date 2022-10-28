using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Seed
{
	internal class AppUserSeed : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			string superAdminPassWord = BCrypt.Net.BCrypt.HashPassword("Super158?.");
			string adminPassword = BCrypt.Net.BCrypt.HashPassword("Sinemis?");
			string userPassWord = BCrypt.Net.BCrypt.HashPassword("user123.");
			builder.HasData
				(
				new AppUser() { Id = 1, UserName = "superadmin", Password = superAdminPassWord, Role = Core.Enums.Role.SuperAdmin, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
				new AppUser() { Id = 2, UserName = "admin", Password = adminPassword, Role = Core.Enums.Role.Admin, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
				new AppUser() { Id = 3, UserName = "user", Password = userPassWord, Role = Core.Enums.Role.User, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
				);
		}
	}
}
