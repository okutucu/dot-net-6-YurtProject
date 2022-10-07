using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FullName).IsRequired().HasMaxLength(30);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(10);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Role).IsRequired().HasMaxLength(15);
            builder.Property(u => u.Identity).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Phone).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Description).IsRequired().HasMaxLength(100);

        }
    }
}
