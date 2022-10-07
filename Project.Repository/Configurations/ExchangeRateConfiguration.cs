using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class ExchangeRateConfiguration : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.Property(e => e.ExchangeName).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Price).HasColumnType("decimal(18,2)");

        }
    }
}
