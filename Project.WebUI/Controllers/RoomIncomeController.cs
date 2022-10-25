using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
	public class RoomIncomeController : Controller
	{
        private readonly IRoomService _roomService;
        private readonly IService<RoomIncome> _roomIncomeService;
        private readonly IMapper _mapper;
		private readonly IExchangeRateService _exchangeRateService;


		public RoomIncomeController(IRoomService roomService, IMapper mapper, IService<RoomIncome> roomIncomeService, IExchangeRateService exchangeRateService)
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
                await _roomService.ReduceDeptAsync(roomIncomeDto.RoomId, roomIncomeDto.Price,currency.Price);
				await _roomIncomeService.AddAsync(_mapper.Map<RoomIncome>(roomIncomeDto));

                return RedirectToAction(nameof(Index));
            }

            return View();
		}


	}
}
