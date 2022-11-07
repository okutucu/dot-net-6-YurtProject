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
			return await _context.IncomeDetails.Include(c => c.Room).ToListAsync();
		}

		public Task<List<IncomeDetail>> GetIncomeWithSingleRoomIdAsync(int roomId)
		{
            return  _context.IncomeDetails.Where(x => x.RoomId == roomId).Include(c => c.Room).ToListAsync();

        }
    }
}
