﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(r => r.RoomName).IsRequired().HasMaxLength(10);
            builder.Property(r => r.Capacity).IsRequired().HasMaxLength(2);
            builder.Property(r => r.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(r => r.Debt).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(r => r.RoomType).HasMaxLength(20);
            builder.Property(r => r.LackDetail).HasMaxLength(150);

                
        }
    }
}