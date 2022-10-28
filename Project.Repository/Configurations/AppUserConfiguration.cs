using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
	internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{

			builder.Property(au => au.UserName).IsRequired().HasMaxLength(20);
			builder.Property(au => au.Password).IsRequired();
			builder.Property(au => au.Role).IsRequired().HasMaxLength(15);

			builder.HasOne(au => au.AppUserDetail).WithOne(ad => ad.AppUser).HasForeignKey<AppUserDetail>(ad => ad.AppUserId);


			builder.ToTable("AppUsers");

		}
	}
}
