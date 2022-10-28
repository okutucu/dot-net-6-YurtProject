using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
	internal class RoomIncomeConfiguration : IEntityTypeConfiguration<RoomIncome>
	{
		public void Configure(EntityTypeBuilder<RoomIncome> builder)
		{
			builder.Property(r => r.Price).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(r => r.MoneyOfTheDay).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(r => r.PaymentDate).HasColumnType("date");
			builder.Property(r => r.Exchange).IsRequired().HasMaxLength(20);
			builder.Property(r => r.PaymentMethod).IsRequired().HasMaxLength(20);
			builder.Property(r => r.Description).HasMaxLength(150);
		}
	}
}
