using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IExchangeRateService : IService<ExchangeRate>
    {
        Task<ExchangeRate> GetByName(string name);
        Task CurrencyUpdate(decimal dollar, decimal euro, decimal sterling);


    }
}
