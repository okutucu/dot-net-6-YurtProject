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
		private readonly IExchangeRateService _exchangeRateService;

		//todo income detail // paymentdetail // room income sadece managmentta mı olacak ??

		public IncomeDetailController(IIncomeDetailService incomeDetailService, IMapper mapper, IExchangeRateService exchangeRateService, IRoomService roomService)
		{
			_incomeDetailService = incomeDetailService;
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
			ViewBag.date = selectedDate;
			List<IncomeWithRoomDto> incomeDetailDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);

            ViewBag.allPaymentsDatas = incomeDetailDtos.GroupBy(p => p.Exchange).Select(group => new
            {
                Exchange = group.Key,
                Sum = group.Sum(s => s.Price)

            });
            ViewBag.detailPaymentsDatas = from payment in incomeDetailDtos
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

            return View(incomeDetailDtos);

		}

		public async Task<IActionResult> Create()
		{
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

			List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View(incomeDetailDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<IncomeDetail>))]
		public async Task<IActionResult> Update(int id)
		{
			List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			IncomeDetail incomeDetail = await _incomeDetailService.GetByIdAsync(id);

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
