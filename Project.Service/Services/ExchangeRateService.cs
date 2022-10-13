using Project.Core.Enums;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class ExchangeRateService : Service<ExchangeRate>, IExchangeRateService
    {
        private readonly IExchangeRateRepository _exchangeRateRepository;

        public ExchangeRateService(IUnitOfWork unitOfWok, IGenericRepository<ExchangeRate> repository, IExchangeRateRepository exchangeRateRepository) : base(unitOfWok, repository)
        {
            _exchangeRateRepository = exchangeRateRepository;
        }
        public async Task<ExchangeRate> GetByName(string name)
        {
            return await _exchangeRateRepository.GetByName(name);
        }

        public async Task CurrencyUpdate(decimal dollar, decimal euro, decimal sterling)
        {
            ExchangeRate newDollar = await _exchangeRateRepository.GetByIdAsync((int)Exchange.Dollar);
            ExchangeRate newEuro = await _exchangeRateRepository.GetByIdAsync((int)Exchange.Euro);
            ExchangeRate newSterling = await _exchangeRateRepository.GetByIdAsync((int)Exchange.Sterling);

            newDollar.Price = dollar;
            newEuro.Price = euro;
            newSterling.Price = sterling;

             _exchangeRateRepository.Update(newDollar);
             _exchangeRateRepository.Update(newEuro);
             _exchangeRateRepository.Update(newSterling);

            await _unitOfWok.CommitAsync();

        }
    }
}
