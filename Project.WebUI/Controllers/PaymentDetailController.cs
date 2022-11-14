using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.Service.Services;

namespace Project.WebUI.Controllers
{
    [Authorize]
    public class PaymentDetailController : Controller
	{
        private readonly IRoomService _roomService;
        private readonly IPaymentDetailService _paymentDetailService;
		private readonly IExchangeRateService _exchangeRateService;
		private readonly IMapper _mapper;

		public PaymentDetailController(IPaymentDetailService paymentDetailService, IMapper mapper, IExchangeRateService exchangeRateService, IRoomService roomService)
		{
			_paymentDetailService = paymentDetailService;
			_mapper = mapper;
			_exchangeRateService = exchangeRateService;
			_roomService = roomService;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}

		public async Task<IActionResult> GetBySelected(string selectedDate)
		{
			List<PaymentDetailWithRoomDto> paymentDetailDtos = await _paymentDetailService.DailyOrMonthly(selectedDate);

			ViewBag.date = selectedDate;

            ViewBag.allPaymentsDatas = paymentDetailDtos.GroupBy(p => p.Exchange).Select(group => new
            {
                Exchange = group.Key,
                Sum = group.Sum(s => s.Price)

            });
            ViewBag.detailPaymentsDatas = from payment in paymentDetailDtos
                                          group payment by payment.PaymentName into payments
                                          select new
                                          {
                                              PaymentName = payments.Key,
                                              PaymentDetail = from paymentDetail in payments
                                                              group paymentDetail by paymentDetail.Exchange into paymentDetailGroup
                                                              select new
                                                              {
                                                                  Exchange = paymentDetailGroup.Key,
                                                                  Sum = paymentDetailGroup.Sum(x => x.Price),
                                                              }
                                          };
            return View(paymentDetailDtos);
		}

        public IActionResult Create()
		{
            List<Room> rooms = _roomService.GetAll().ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

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
            List<Room> rooms = _roomService.GetAll().ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");
            return View(paymentDetailDto);
		}


		[ServiceFilter(typeof(NotFoundFilter<PaymentDetail>))]
		public async Task<IActionResult> Update(int id)
		{
            PaymentDetail paymentDetail = await _paymentDetailService.GetByIdAsync(id);


            List<Room> rooms = _roomService.GetAll().ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", paymentDetail.RoomId);

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

            List<Room> rooms = _roomService.GetAll().ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", paymentDetailDto.RoomId);

            return View(paymentDetailDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<PaymentDetail>))]
		public async Task<IActionResult> Remove(int id)
		{
			PaymentDetail paymentDetail = await _paymentDetailService.GetByIdAsync(id);
			await _paymentDetailService.RemoveAsync(paymentDetail);
			return RedirectToAction(nameof(Index));

		}
	}
}
