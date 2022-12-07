using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    [Authorize]
    public class PaymentDetailController : Controller
	{
        private readonly IRoomService _roomService;
        private readonly IPaymentDetailService _paymentDetailService;
		private readonly IExchangeRateService _exchangeRateService;
		private readonly IMapper _mapper;
        private readonly IService<PaymentName> _paymentNameService;


		public PaymentDetailController(IPaymentDetailService paymentDetailService, IMapper mapper, IExchangeRateService exchangeRateService, IRoomService roomService, IService<PaymentName> paymentNameService)
		{
			_paymentDetailService = paymentDetailService;
			_mapper = mapper;
			_exchangeRateService = exchangeRateService;
			_roomService = roomService;
			_paymentNameService = paymentNameService;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}

        [HttpGet]
        public async Task<JsonResult> VisualizePaymentResult(string selectedDate)
        {
            List<PaymentDetailWithRoomDto> paymentWithRoomDtos = await _paymentDetailService.DailyOrMonthly(selectedDate);
            var allDataWithExchange = (from exchange in paymentWithRoomDtos
                                                group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                                                select new
                                                {
                                                    Exchange = exchangeGroup.Key,
                                                    Sum = exchangeGroup.Sum(s => s.Price)
                                                }).ToList();

            var allDataWithPaymentMethod = paymentWithRoomDtos.GroupBy(
                x => new { x.PaymentMethod, x.Exchange }
               ).Select(g => new
               {
                   PaymentMethod = g.Key.PaymentMethod.ToString(),
                   Exchange = g.Key.Exchange.ToString(),
                   Sum = g.Sum(s => s.Price)
               }).ToList();

            var allPaymentDetail = new
            {
                allDataWithExchange,
                allDataWithPaymentMethod
            };

            return Json(allPaymentDetail);
        }

        public async Task<IActionResult> GetBySelected(string selectedDate)
		{
			List<PaymentDetailWithRoomDto> paymentDetailDtos = await _paymentDetailService.DailyOrMonthly(selectedDate);
            ViewBag.url = "/PaymentDetail/VisualizePaymentResult?selectedDate=";
            ViewBag.date = selectedDate;
            ViewBag.detailPaymentsDatas = from payment in paymentDetailDtos
                                          group payment by payment.PaymentName.Name into payments
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
            List<PaymentName> paymentNames = _paymentNameService.GetAll().ToList();

            List<PaymentNameDto> paymentNamesDto = _mapper.Map<List<PaymentNameDto>>(paymentNames);

            ViewBag.paymentNames = new SelectList(paymentNamesDto, "Id", "Name");

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


            List<PaymentName> paymentNames = _paymentNameService.GetAll().ToList();

            List<PaymentNameDto> paymentNamesDto = _mapper.Map<List<PaymentNameDto>>(paymentNames);

            ViewBag.paymentNames = new SelectList(paymentNamesDto, "Id", "Name");

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
