using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class ExchangeRateRepository : GenericRepository<ExchangeRate>, IExchangeRateRepository
    {
        public ExchangeRateRepository(YurtDbContext context) : base(context)
        {
        }

        public async Task<ExchangeRate> GetByName(string name)
        {
            return await _context.ExchangeRates.AsNoTracking().FirstOrDefaultAsync(e => e.ExchangeName == name);
        }
    }
}
