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
    public class RoomIncomeRepository : GenericRepository<RoomIncome>, IRoomIncomeRepository
    {
        public RoomIncomeRepository(YurtDbContext context) : base(context)
        {
        }

        public async Task<List<RoomIncome>> GetIncomeWithRoomAsync()
        {
            return await _context.RoomIncomes.Include(c => c.Room).ToListAsync();
        }
    }
}
