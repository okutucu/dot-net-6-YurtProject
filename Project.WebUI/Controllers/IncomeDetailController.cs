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
    public class IncomeDetailController : Controller
	{
		private readonly IIncomeDetailService _incomeDetailService;
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;
        private readonly IService<PaymentName> _paymentNameService;
        private readonly IExchangeRateService _exchangeRateService;


		public IncomeDetailController(IIncomeDetailService incomeDetailService, IMapper mapper, IExchangeRateService exchangeRateService, IRoomService roomService, IService<PaymentName> paymentNameService)
		{
			_incomeDetailService = incomeDetailService;
			_mapper = mapper;
			_exchangeRateService = exchangeRateService;
			_roomService = roomService;
			_paymentNameService = paymentNameService;
		}


		public async Task<IActionResult> Index()
		{
			return View();
		}


		public async Task<IActionResult> GetBySelected(string selectedDate)
		{
            ViewBag.url = "/IncomeDetail/VisualizeOtherIncomesResult?selectedDate=";

            ViewBag.date = selectedDate;
			List<IncomeWithRoomDto> incomeDetailDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);

            ViewBag.detailPaymentsDatas = from payment in incomeDetailDtos
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

            return View(incomeDetailDtos);

		}



        [HttpGet]
        public async Task<JsonResult> VisualizeOtherIncomesResult(string selectedDate)
        {
            List<IncomeWithRoomDto> incomeWithRoomDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);
            var allDataWithExchange = (from exchange in incomeWithRoomDtos
                                                group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                                                select new
                                                {
                                                    Exchange = exchangeGroup.Key,
                                                    Sum = exchangeGroup.Sum(s => s.Price)
                                                }).ToList();


            var allDataWithPaymentMethod = incomeWithRoomDtos.GroupBy(
       x => new { x.PaymentMethod, x.Exchange }
      ).Select(g => new
      {
          PaymentMethod = g.Key.PaymentMethod.ToString(),
          Exchange = g.Key.Exchange.ToString(),
          Sum = g.Sum(s => s.Price)
      }).ToList();


            var allIncomesDetail = new
            {
                allDataWithExchange,
                allDataWithPaymentMethod
            };

            return Json(allIncomesDetail);
        }
        public async Task<IActionResult> Create()
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
		public async Task<IActionResult> Create(IncomeDetailDto incomeDetailDto)
		{
			if (ModelState.IsValid)
			{
				ExchangeRate currency = await _exchangeRateService.GetByName(incomeDetailDto.Exchange.ToString());
				await _incomeDetailService.AddByCurrency(incomeDetailDto, currency.Price);
				return RedirectToAction(nameof(Index));
			}


            List<PaymentName> paymentNames = _paymentNameService.GetAll().ToList();

            List<PaymentNameDto> paymentNamesDto = _mapper.Map<List<PaymentNameDto>>(paymentNames);

            ViewBag.paymentNames = new SelectList(paymentNamesDto, "Id", "Name");

            List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View(incomeDetailDto);
		}



		[ServiceFilter(typeof(NotFoundFilter<IncomeDetail>))]
		public async Task<IActionResult> Update(int id)
		{

            IncomeDetail incomeDetail = await _incomeDetailService.GetByNoTrackIdAsync(id);

            List<PaymentName> paymentNames = _paymentNameService.GetAll().ToList();

            List<PaymentNameDto> paymentNamesDto = _mapper.Map<List<PaymentNameDto>>(paymentNames);

            ViewBag.paymentNames = new SelectList(paymentNamesDto, "Id", "Name",incomeDetail.PaymentNameId);


            List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", incomeDetail.Id);

			return View(_mapper.Map<IncomeDetailDto>(incomeDetail));
		}

		[HttpPost]
		public async Task<IActionResult> Update(IncomeDetailDto incomeDetailDto)
		{
			if (ModelState.IsValid)
			{
				ExchangeRate currency = await _exchangeRateService.GetByName(incomeDetailDto.Exchange.ToString());
				await _incomeDetailService.UpdateByCurrency(incomeDetailDto, currency.Price);

				return RedirectToAction(nameof(Index));
			}

			List<Room> rooms = _roomService.GetAll().ToList();
			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", incomeDetailDto.Id);


            List<PaymentName> paymentNames = _paymentNameService.GetAll().ToList();
            List<PaymentNameDto> paymentNamesDto = _mapper.Map<List<PaymentNameDto>>(paymentNames);
            ViewBag.paymentNames = new SelectList(paymentNamesDto, "Id", "Name", incomeDetailDto.PaymentNameId);

            return View(incomeDetailDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<IncomeDetail>))]
		public async Task<IActionResult> Remove(int id)
		{
			IncomeDetail incomeDetail = await _incomeDetailService.GetByIdAsync(id);
			await _incomeDetailService.RemoveAsync(incomeDetail);
			return RedirectToAction(nameof(Index));
		}



	}
}
