using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper, IRoomService roomService)
        {
            _customerService = customerService;
            _mapper = mapper;
            _roomService = roomService;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _customerService.GetCustomerWithRoomAsync());
        }

        public  async Task<IActionResult> Create()
        {
            List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();

            List<RoomDto> roomsDto =  _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerDto customerDto)
        {
            if(ModelState.IsValid)
            {
                await _roomService.ReducingRoomCapacity(customerDto.RoomId);

                await _customerService.AddAsync(_mapper.Map<Customer>(customerDto));
                return RedirectToAction(nameof(Index));
            }
 
            List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

            return View();
        }
    }
}
