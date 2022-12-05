using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class RoomIncomeController : Controller
	{
		private readonly IRoomService _roomService;
		private readonly IRoomIncomeService _roomIncomeService;
		private readonly IMapper _mapper;
		private readonly IExchangeRateService _exchangeRateService;


		public RoomIncomeController(IRoomService roomService, IMapper mapper, IRoomIncomeService roomIncomeService, IExchangeRateService exchangeRateService)
		{
			_roomService = roomService;
			_mapper = mapper;
			_roomIncomeService = roomIncomeService;
			_exchangeRateService = exchangeRateService;

		}

		public IActionResult Index()
		{
			return View();
		}

        [HttpGet]
        public async Task<IActionResult> GetBySelected(string selectedDate)
		{
			List<RoomIncomeWithRoomDto> roomDetailsDto = await _roomIncomeService.DailyOrMonthly(selectedDate);

            ViewBag.url = "/RoomIncome/VisualizeRoomRentResult?selectedDate=";
            ViewBag.date = selectedDate;
            ViewBag.allPaymentsDatas = roomDetailsDto.GroupBy(p => p.Exchange).Select(group => new
            {
                Exchange = group.Key,
                Sum = group.Sum(s => s.Price)

            });

            return View(roomDetailsDto);

		}


        [HttpGet]
        public async Task<JsonResult> VisualizeRoomRentResult(string selectedDate)
        {
            List<RoomIncomeWithRoomDto> roomIncomeWithRoomDtos = await _roomIncomeService.DailyOrMonthly(selectedDate);
            var allDataWithExchange = (from exchange in roomIncomeWithRoomDtos
                                              group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                                              select new
                                              {
                                                  Exchange = exchangeGroup.Key,
                                                  Sum = exchangeGroup.Sum(s => s.Price)
                                              }).ToList();


            var allDataWithPaymentMethod = roomIncomeWithRoomDtos.GroupBy(
                   x => new { x.PaymentMethod, x.Exchange }
                  ).Select(g => new
                  {
                      PaymentMethod = g.Key.PaymentMethod.ToString(),
                      Exchange = g.Key.Exchange.ToString(),
                      Sum = g.Sum(s => s.Price)
                  }).ToList();




            var allRentIncomes = new
            {
                allDataWithExchange,
                allDataWithPaymentMethod
            };

            return Json(allRentIncomes);
        }

        public IActionResult Create()
		{

            List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
			
            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(RoomIncomeDto roomIncomeDto)
		{
			if (ModelState.IsValid)
			{
				ExchangeRate currency = await _exchangeRateService.GetByName(roomIncomeDto.Exchange.ToString());

				await _roomService.ReduceDeptAsync(roomIncomeDto.RoomId, roomIncomeDto.Price, currency.Price);

				await _roomIncomeService.AddByCurrency(roomIncomeDto, currency.Price);
				return RedirectToAction(nameof(Index));
			}

            List<Room> rooms = _roomService.GetAll().ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");
            return View(roomIncomeDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<RoomIncome>))]
		public async Task<IActionResult> Update(int id)
		{
			RoomIncome roomIncome = await _roomIncomeService.GetByIdAsync(id);

			List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", roomIncome.RoomId);

			return View(_mapper.Map<RoomIncomeDto>(roomIncome));
		}

		[HttpPost]
		public async Task<IActionResult> Update(RoomIncomeDto roomIncomeDto)
		{
			if (ModelState.IsValid)
			{
				RoomIncomeWithRoomDto roomIncomeWithRoomDto = await _roomIncomeService.GetIncomeWithSingleRoomAsync(roomIncomeDto.Id);
				ExchangeRate currency = await _exchangeRateService.GetByName(roomIncomeDto.Exchange.ToString());


				await _roomService.ChangeRoomIncomesByRoomIncomesAsync(roomIncomeWithRoomDto, roomIncomeDto.RoomId, currency.Price, roomIncomeDto.Price);
				await _roomIncomeService.UpdateByCurrency(roomIncomeDto, currency.Price);

				return RedirectToAction(nameof(Index));

			}

			List<Room> rooms = _roomService.GetAll().ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", roomIncomeDto.RoomId);

			return View(roomIncomeDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<RoomIncome>))]

		public async Task<IActionResult> Remove(int id)
		{
			RoomIncome roomIncome = await _roomIncomeService.GetByIdAsync(id);
			await _roomService.IncreaseRoomDebtWhenDeletingIncomesAsync((int)roomIncome.RoomId, roomIncome.MoneyOfTheDay);
			await _roomIncomeService.RemoveAsync(roomIncome);
			return RedirectToAction(nameof(Index));
		}


	}
}
