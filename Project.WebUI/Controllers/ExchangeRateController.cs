using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    [Authorize(Policy = "AdminPolicy")]

    public class ExchangeRateController : Controller
	{
		private readonly IService<ExchangeRate> _service;
		private readonly IExchangeRateService _exchangeRateService;
		private readonly IMapper _mapper;

		public ExchangeRateController(IService<ExchangeRate> service, IMapper mapper, IExchangeRateService exchangeRateService)
		{
			_service = service;
			_mapper = mapper;
			_exchangeRateService = exchangeRateService;
		}

		public async Task<IActionResult> Index()
		{
			List<ExchangeRate> exchangeRates = _service.GetAll().ToList();

			List<ExchangeRateDto> exchangeRateDto = _mapper.Map<List<ExchangeRateDto>>(exchangeRates);

			return View(exchangeRateDto);
		}

		[HttpPost]
		public async Task<IActionResult> Update(decimal dollar, decimal euro, decimal sterling)
		{

			await _exchangeRateService.CurrencyUpdate(dollar, euro, sterling);
			return RedirectToAction(nameof(Index));
		}
	}
}
