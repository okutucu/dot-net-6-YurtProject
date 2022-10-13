﻿using AutoMapper;
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
    }
}
