using Project.Core.Models;

namespace Project.Core.Repositories
{
	public interface IExchangeRateRepository : IGenericRepository<ExchangeRate>
	{
		Task<ExchangeRate> GetByName(string name);
	}
}
