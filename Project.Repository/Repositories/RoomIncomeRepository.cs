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
			return await _context.RoomIncomes.Include(r => r.Room).ToListAsync();
		}

		public async Task<RoomIncome> GetIncomeWithSingleRoomAsync(int roomIncomeId)
		{
			return _context.RoomIncomes.Include(r => r.Room).Where(r => r.Id == roomIncomeId).AsNoTracking().SingleOrDefault();
		}
	}
}
