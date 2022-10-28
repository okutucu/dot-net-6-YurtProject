using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				new AppUser() { Id = 1, UserName = "superadmin", Password = superAdminPassWord, Role=Core.Enums.Role.SuperAdmin },
				new AppUser() { Id = 2, UserName = "admin", Password = adminPassword, Role = Core.Enums.Role.Admin},
				new AppUser() { Id = 3, UserName = "user", Password = userPassWord, Role=Core.Enums.Role.User }
				) ;
		}
	}
}
