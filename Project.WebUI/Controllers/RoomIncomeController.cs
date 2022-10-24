using System;
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
        private readonly IMapper _mapper;


        public RoomIncomeController(IRoomService roomService, IMapper mapper)
		{
			_roomService = roomService;
			_mapper = mapper;
		}

        public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<JsonResult> GetByDept(int id)
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
	}
}
