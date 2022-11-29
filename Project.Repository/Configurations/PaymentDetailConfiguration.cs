using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
	internal class PaymentDetailConfiguration : IEntityTypeConfiguration<PaymentDetail>
	{
		public void Configure(EntityTypeBuilder<PaymentDetail> builder)
		{
			builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(p => p.MoneyOfTheDay).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(p => p.PaymentDate).HasColumnType("date");
			builder.Property(p => p.Exchange).IsRequired().HasMaxLength(20);
			builder.Property(p => p.PaymentMethod).IsRequired().HasMaxLength(20);
			builder.Property(p => p.Description).HasMaxLength(150);
		}
	}
}
