using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
	internal class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
	{
		public void Configure(EntityTypeBuilder<RoomType> builder)
		{
			builder.Property(e => e.RoomName).IsRequired().HasMaxLength(30);
			builder.Property(e => e.Price).HasColumnType("decimal(18,2)");
			builder.Property(e => e.IncreasedPrice).HasColumnType("decimal(18,2)");
		}
	}
}
