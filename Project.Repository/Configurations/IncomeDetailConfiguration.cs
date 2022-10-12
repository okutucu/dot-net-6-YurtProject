using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class IncomeDetailConfiguration : IEntityTypeConfiguration<IncomeDetail>
    {
        public void Configure(EntityTypeBuilder<IncomeDetail> builder)
        {
            builder.Property(i => i.RoomName).IsRequired().HasMaxLength(10);
            builder.Property(i => i.PaymentName).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(i => i.MoneyOfTheDay).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(i => i.Exchange).IsRequired().HasMaxLength(20);
            builder.Property(i => i.PaymentMethod).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Description).HasMaxLength(150);
        }
    }
}
