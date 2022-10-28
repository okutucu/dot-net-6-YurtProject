using Project.Core.Models;

namespace Project.Core.Repositories
{
	public interface IRoomIncomeRepository : IGenericRepository<RoomIncome>
	{
		Task<List<RoomIncome>> GetIncomeWithRoomAsync();
		Task<RoomIncome> GetIncomeWithSingleRoomAsync(int roomIncomeId);


	}
}
