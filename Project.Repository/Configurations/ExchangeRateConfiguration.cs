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


			builder.HasData(
				new ExchangeRate
				{
					Id = 1,
					ExchangeName = "Dollar",
					Price = 10,
					CreatedDate = DateTime.Now
				},
				  new ExchangeRate
				  {
					  Id = 2,
					  ExchangeName = "Euro",
					  Price = 10,
					  CreatedDate = DateTime.Now
				  },
					new ExchangeRate
					{
						Id = 3,
						ExchangeName = "Sterling",
						Price = 10,
						CreatedDate = DateTime.Now
					},
					new ExchangeRate
					{
						Id = 4,
						ExchangeName = "Tl",
						Price = 1,
						CreatedDate = DateTime.Now
					}
				
				);
		}
	}
}
