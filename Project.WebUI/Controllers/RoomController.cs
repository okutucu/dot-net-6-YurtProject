using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.ControllersR
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
        public async Task<IActionResult> Index()
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
        public async Task<IActionResult> Create(RoomCreateDto roomCreateDto)
        {
            if (ModelState.IsValid)
            {
                roomCreateDto.CurrentCapacity = roomCreateDto.Capacity;

                await _roomService.AddAsync(_mapper.Map<Room>(roomCreateDto));
                return RedirectToAction(nameof(Index));
            }

            return View(roomCreateDto);
        }


        [ServiceFilter(typeof(NotFoundFilter<Room>))]
        public async Task<IActionResult> Update(int id)
        {
            Room room = await _roomService.GetByIdAsync(id);
            RoomUpdateDto roomDto = _mapper.Map<RoomUpdateDto>(room);
            return View(roomDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoomUpdateDto roomUpdateDto)
        {
            if (ModelState.IsValid)
            {
                Room room = await _roomService.GetByIdAsync(roomUpdateDto.Id);
                roomUpdateDto.CurrentCapacity = roomUpdateDto.Capacity - room.Capacity;
                roomUpdateDto.Debt = room.Debt;
          

                await _roomService.UpdateAsync(_mapper.Map<Room>(roomUpdateDto));
                return RedirectToAction(nameof(Index));
                 
            }

            return View(roomUpdateDto);

        }


        [ServiceFilter(typeof(NotFoundFilter<Room>))]

        public async Task<IActionResult> Detail(int id)
        {
            RoomWithCustomerDto roomAndCustomerDto = await _roomService.GetSingleRoomByIdWithCustomerAsync(id);

            return View(roomAndCustomerDto);
        }

        public async Task<IActionResult> Remove(int id)
        {
            Room room = await _roomService.GetByIdAsync(id);
            await _roomService.RemoveAsync(room);
            return RedirectToAction(nameof(Index));

        }
    }
}
