using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
	public class RoomReportController : Controller
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;

		public RoomReportController(IRoomService roomService, IMapper mapper)
		{
			_roomService = roomService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			List<Room> rooms =  _roomService.GetAll().ToList();
			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

            return View();
		}
	}
}
