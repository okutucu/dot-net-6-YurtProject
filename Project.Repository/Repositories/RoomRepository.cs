using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<List<Room>> GetRoomWithCustomer()
        {
            // Eager Loading
            return await _context.Rooms.Include(x => x.Customers).ToListAsync();
        }
    }
}
