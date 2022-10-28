using Project.Core.Models;

namespace Project.Core.Repositories
{
	public interface IIncomeDetailRepository : IGenericRepository<IncomeDetail>
	{
		Task<List<IncomeDetail>> GetIncomeWithRoomAsync();

	}
}
