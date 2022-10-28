using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
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

		[HttpPost]
		public async Task<JsonResult> GetByDebt(int id)
		{
			Room room = await _roomService.GetByIdAsync(id);

			JsonResult result = Json(room.Debt);

			return result;
		}

		public async Task<IActionResult> GetBySelected(DateTime selectedDate)
		{
			List<RoomIncomeWithRoomDto> roomDetailsDto = await _roomIncomeService.GetByMonth(selectedDate);
			return View(roomDetailsDto);

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
			return View();
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

			await _roomService.IncreaseRoomDebtWhenDeletingIncomesAsync(roomIncome.RoomId, roomIncome.MoneyOfTheDay);
			await _roomIncomeService.RemoveAsync(roomIncome);
			return RedirectToAction(nameof(Index));

		}


	}
}
