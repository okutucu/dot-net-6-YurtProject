using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        public async  Task<IActionResult> Index()
        {
            List<Room> rooms = _roomService.GetAll().ToList();
            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            return View(roomsDto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomCreateDto roomCreateDto)
        {
            return View();
        }
    }
}
