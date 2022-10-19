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

            return View(customerDto);
        }


        public async Task<IActionResult> Update(int id)
        {
            List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();
            Customer customer = await _customerService.GetByIdAsync(id);

            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName",customer.RoomId);

            return View(_mapper.Map<CustomerDto>(customer));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CustomerDto customerDto)
        {
            if (ModelState.IsValid)
            {
                Customer customer = await _customerService.GetByIdAsync(customerDto.Id);  
                if (customerDto.RoomId == customer.RoomId)
                {
                    await _customerService.UpdateAsync(_mapper.Map<Customer>(customerDto));
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    await _roomService.GetCustomerWithRoomForRoomChange(customer.RoomId, customerDto.RoomId);  
                    await _customerService.UpdateAsync(_mapper.Map<Customer>(customerDto));
                     return RedirectToAction(nameof(Index));
                }
            }

            List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();
            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", customerDto.RoomId);
            return View(customerDto);

        }

         public async Task<IActionResult> Remove(int id)
        {
            Customer customer = await _customerService.GetByIdAsync(id);
            await _roomService.IncreaseCapacityWhenDeletingCustomers(customer.RoomId);
            await _customerService.RemoveAsync(customer);
            return RedirectToAction(nameof(Index));

        }
    }

}
