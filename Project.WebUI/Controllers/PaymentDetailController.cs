using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Enums;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class PaymentDetailController : Controller
    {
        private readonly IPaymentDetailService _paymentDetailService;
        private readonly IExchangeRateService _exchangeRateService;
        private readonly IMapper _mapper;

        public PaymentDetailController(IPaymentDetailService paymentDetailService, IMapper mapper, IExchangeRateService exchangeRateService)
        {
            _paymentDetailService = paymentDetailService;
            _mapper = mapper;
            _exchangeRateService = exchangeRateService;
        }

        public async Task<IActionResult> Index()
        {
            List<PaymentDetail> paymentDetails = _paymentDetailService.GetAll().ToList();

            return View(_mapper.Map<List<PaymentDetailDto>>(paymentDetails));
        }

        public IActionResult GetBySelected(int year, int month, string monthName,string day)
         {

            return View();

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PaymentDetailDto paymentDetailDto)
        {
            if (ModelState.IsValid)
            {
                ExchangeRate currency = await _exchangeRateService.GetByName(paymentDetailDto.Exchange.ToString());
                await _paymentDetailService.AddByCurrency(paymentDetailDto, currency.Price);
                return RedirectToAction(nameof(Index));
            }
            return View(paymentDetailDto);
        }

        [ServiceFilter(typeof(NotFoundFilter<PaymentDetail>))]
        public async Task<IActionResult> Update(int id)
        {
            PaymentDetail paymentDetail = await _paymentDetailService.GetByIdAsync(id); 
            return View(_mapper.Map<PaymentDetailDto>(paymentDetail));
        }
        [HttpPost]
        public async Task<IActionResult> Update(PaymentDetailDto paymentDetailDto)
        {
            if (ModelState.IsValid)
            {
                ExchangeRate currency = await _exchangeRateService.GetByName(paymentDetailDto.Exchange.ToString());
                await _paymentDetailService.UpdateByCurrency(paymentDetailDto, currency.Price);

                return RedirectToAction(nameof(Index));
            }


            return View(paymentDetailDto);
        }

        public async Task<IActionResult> Remove(int id)
        {
           PaymentDetail paymentDetail = await _paymentDetailService.GetByIdAsync(id);
            await _paymentDetailService.RemoveAsync(paymentDetail);
            return RedirectToAction(nameof(Index));



        }
    }
}
