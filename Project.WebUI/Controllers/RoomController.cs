using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.ControllersR
{
    [Authorize]
    public class RoomController : Controller
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;
		private readonly IService<RoomType> _roomTypeService;
		private readonly IWebHostEnvironment _env;
		public RoomController(IRoomService roomService, IMapper mapper, IService<RoomType> roomTypeService, IWebHostEnvironment env)
		{
			_roomService = roomService;
			_mapper = mapper;
			_roomTypeService = roomTypeService;
			_env = env;
		}
		public async Task<IActionResult> Index()
		{
			return View(await _roomService.GetRoomWithRoomTypeAsync());
		}

        [HttpGet]
        public async Task<JsonResult> GetBySingleRoomByIdWithCustomer(int id)
        {
            RoomWithCustomerDto roomsWithCustomer = await _roomService.GetSingleRoomByIdWithCustomerAsync(id);
            JsonResult result = Json(roomsWithCustomer.Customers);

            return result;
        }

        [HttpGet]
        public async Task<JsonResult> GetByDebt(int id)
        {
            Room room = await _roomService.GetByIdAsync(id);

            JsonResult result = Json(room.Debt);

            return result;
        }

        public IActionResult Create()
		{
			List<RoomType> roomTypes = _roomTypeService.GetAll().ToList();
			List<RoomTypeDto> roomTypesDto = _mapper.Map<List<RoomTypeDto>>(roomTypes);

			ViewBag.roomTypes = new SelectList(roomTypesDto, "Id", "RoomName");

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(RoomCreateDto roomCreateDto)
		{
			if (ModelState.IsValid)
			{

				string filePath = Path.Combine(_env.WebRootPath, "resimler");
				if (!Directory.Exists(filePath))
				{
					Directory.CreateDirectory(filePath);
				}


                string fullFileName = Path.Combine(filePath, roomCreateDto.File.FileName);

                using (FileStream fileFlow = new FileStream(fullFileName,FileMode.Create))
				{
					await roomCreateDto.File.CopyToAsync(fileFlow);
                }

				roomCreateDto.FileName = roomCreateDto.File.FileName;
                roomCreateDto.CurrentCapacity = roomCreateDto.Capacity;

				await _roomService.AddAsync(_mapper.Map<Room>(roomCreateDto));
				return RedirectToAction(nameof(Index));
			}

            List<RoomType> roomTypes = _roomTypeService.GetAll().ToList();
            List<RoomTypeDto> roomTypesDto = _mapper.Map<List<RoomTypeDto>>(roomTypes);

            ViewBag.roomTypes = new SelectList(roomTypesDto, "Id", "RoomName");

            return View(roomCreateDto);
		}


		[ServiceFilter(typeof(NotFoundFilter<Room>))]
		public async Task<IActionResult> Update(int id)
		{

			Room room = await _roomService.GetByIdAsync(id);

			List<RoomType> roomTypes = _roomTypeService.GetAll().ToList();
			List<RoomTypeDto> roomTypesDto = _mapper.Map<List<RoomTypeDto>>(roomTypes);
			ViewBag.roomTypes = new SelectList(roomTypesDto, "Id", "RoomName", room.RoomTypeId);

			return View(_mapper.Map<RoomUpdateDto>(room));
		}

		[HttpPost]
		public async Task<IActionResult> Update(RoomUpdateDto roomUpdateDto)
		{
			if (ModelState.IsValid)
			{

				RoomUpdateDto roomDto = await _roomService.RoomCapacityAccuracyAsync(roomUpdateDto);
				await _roomService.UpdateAsync(_mapper.Map<Room>(roomDto));
				return RedirectToAction(nameof(Index));

			}

			List<RoomType> roomTypes = _roomTypeService.GetAll().ToList();
			List<RoomTypeDto> roomTypesDto = _mapper.Map<List<RoomTypeDto>>(roomTypes);
			ViewBag.roomTypes = new SelectList(roomTypesDto, "Id", "RoomName", roomUpdateDto.RoomTypeId);
			return View(roomUpdateDto);
		}


		[ServiceFilter(typeof(NotFoundFilter<Room>))]
		public async Task<IActionResult> Detail(int id)
		{
			RoomWithCustomerDto roomAndCustomerDto = await _roomService.GetSingleRoomByIdWithCustomerAsync(id);

			return View(roomAndCustomerDto);
		}

		public async Task<JsonResult> Remove(int id)
		{
			Room room = await _roomService.GetByIdAsync(id);
			await _roomService.RemoveAsync(room);
            JsonResult result = Json(room.RoomName);
            return result;
        }

    }
}
