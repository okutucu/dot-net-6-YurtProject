using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(YurtDbContext context) : base(context)
        {
        }

        public async Task<List<Room>> GetRoomWithCustomerAsync()
        {
            // Eager Loading
            return await _context.Rooms.Include(x => x.Customers).ToListAsync();
        }

        public async Task<Room> GetSingleRoomByIdWithCustomerAsync(int roomId)
        {
            return await _context.Rooms.Include(x => x.Customers).Where(x => x.Id == roomId).SingleOrDefaultAsync();
        }

        public async Task<Room> ReducingRoomCapacity(int roomId)
        {
            return await _context.Rooms.Where(x => x.Id == roomId).SingleOrDefaultAsync();
        }

        public async Task<Room> RoomCapacityAccuracyAndDebt(int roomId)
        {
            return await _context.Rooms.Where(x => x.Id == roomId).SingleOrDefaultAsync();

        }
    }
}
