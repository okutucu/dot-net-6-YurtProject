using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
	public class IncomeDetailRepository : GenericRepository<IncomeDetail>, IIncomeDetailRepository
	{
		public IncomeDetailRepository(YurtDbContext context) : base(context)
		{
		}

		public async Task<List<IncomeDetail>> GetIncomeWithRoomAsync()
		{
			return await _context.IncomeDetails.Include(i => i.Room).ToListAsync();
		}

		public async Task<List<IncomeDetail>> GetIncomeWithSingleRoomIdAsync(int roomId)
		{
            return await  _context.IncomeDetails.Where(i => i.RoomId == roomId).Include(i => i.Room).ToListAsync();

        }
    }
}
