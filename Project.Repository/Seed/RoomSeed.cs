using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Seed
{
    internal class RoomSeed : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {

            builder.HasData(
                new Room
                {
                    Id = 1,
                    RoomName = "1000",
                    Capacity = 2,
                    CurrentCapacity = 0,
                    Price = 1300,
                    Debt = 0,
                    RoomType = "Economy",
                    Lack = true,
                    LackDetail = "TV is broken"
                },
                   new Room
                   {
                       Id = 2,
                       RoomName = "1001",
                       Capacity = 2,
                       CurrentCapacity = 2,
                       Price = 1500,
                       Debt = 0,
                       RoomType = "Luxery",
                       Lack = false,
                       LackDetail = null,
                   }

                );
        }
    }
}
