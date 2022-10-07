using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            // Bu metodları ef core otomatik gerçekleştirir.

            builder.Property(c => c.FullName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.IdentityNo).HasMaxLength(20);
            builder.Property(c => c.Phone).HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.EntryDate).IsRequired().HasColumnType("date");
            builder.Property(c => c.Depart).HasColumnType("date");
            builder.Property(c => c.RelativeNameSurname).HasMaxLength(50);
            builder.Property(c => c.RelativePhone).HasMaxLength(20);
            builder.Property(c => c.Description).HasMaxLength(150);
            builder.Property(c => c.CreatedDate).IsRequired().HasColumnType("date");


            builder.ToTable("Customers");
        }
    }
}
