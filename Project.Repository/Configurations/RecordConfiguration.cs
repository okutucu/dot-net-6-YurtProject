using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.Property(rc => rc.RoomName).IsRequired().HasMaxLength(10);
            builder.Property(rc => rc.FullName).IsRequired().HasMaxLength(50);
            builder.Property(rc => rc.IdentityNo).HasMaxLength(20);
            builder.Property(rc => rc.Phone).HasMaxLength(20);
            builder.Property(rc => rc.EntryDate).HasColumnType("date");
            builder.Property(rc => rc.Depart).HasColumnType("date");
        }
    }
}
