using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Abstractions.File;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.WebUI.ViewModel;

namespace Project.WebUI.Controllers
{
	[Authorize]
    public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;
		private readonly IRecordService _recordService;
		private readonly ICustomerImageFileService _customerImageFileService;
		private readonly IFileService _fileService;

		public CustomerController(ICustomerService customerService, IMapper mapper, IRoomService roomService, IRecordService recordService, ICustomerImageFileService customerImageFileService, IFileService fileService)
		{
			_customerService = customerService;
			_mapper = mapper;
			_roomService = roomService;
			_recordService = recordService;
			_customerImageFileService = customerImageFileService;
			_fileService = fileService;
		}
		public async Task<IActionResult> Index()
		{
            return View(await _customerService.GetCustomerWithRoomAsync());
		}

        public async Task<IActionResult> Detail(int id)
        {

            Customer customer = await _customerService.GetSingleCustomerWithImageAsync(id);

            CustomerWithImage_VM customerWithImage_VM = new()
            {
                Customer = customer,
                CustomerImageFile = customer.CustomerImageFiles
            };

            return View(customerWithImage_VM);
        } 
        public async Task<IActionResult> Create()
		{
			List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CustomerDto customerDto)
		{
			if (ModelState.IsValid)
			{
				await _roomService.ReducingRoomCapacityAsync(customerDto.RoomId);

				await _customerService.AddAsync(_mapper.Map<Customer>(customerDto));

				return RedirectToAction(nameof(Index));
			}

			List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View(customerDto);
		}

		[HttpGet]
		public async Task<IActionResult> Upload(int id)
		{
			Customer customer = await _customerService.GetSingleCustomerWithImageAsync(id);

			CustomerWithImage_VM customerWithImage_VM = new()
			{
				Customer = customer,
				CustomerImageFile = customer.CustomerImageFiles
			};

			return PartialView("_CustomerImagePartialView", customerWithImage_VM);
		}


		[HttpPost]
		public async Task<JsonResult> Upload(string id)
		{
			List<(string fileName , string path)> datas = await _fileService.UploadAsync("resource/customer-images", Request.Form.Files);

			Customer customer = await _customerService.GetByNoTrackIdAsync(int.Parse(id));

			await _customerImageFileService.AddRangeAsync(datas.Select(d => new CustomerImageFile()
			{
				FileName = d.fileName,
				Path = d.path, 
				Customers = new List<Customer>() { customer}
			}).ToList());

			
			return Json("Your transaction has been completed successfully");
		}




		[ServiceFilter(typeof(NotFoundFilter<Customer>))]
		public async Task<IActionResult> Update(int id)
		{

			Customer customer = await _customerService.GetByIdAsync(id);
            List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0 || r.Id == customer.RoomId).ToList();
            List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", customer.RoomId);

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
				}
				else
				{
					await _roomService.GetCustomerWithRoomForRoomChangeAsync((int)customer.RoomId, customerDto.RoomId);
					await _customerService.UpdateAsync(_mapper.Map<Customer>(customerDto));
				}

                return RedirectToAction(nameof(Index));
            }

			List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0 || r.Id == customerDto.Id).ToList();
			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName", customerDto.RoomId);
			return View(customerDto);

		}

		[ServiceFilter(typeof(NotFoundFilter<Customer>))]
		public async Task<IActionResult> Remove(int id)
		{
			Customer customer = await _customerService.GetByIdAsync(id);
			RoomWithCustomerDto roomWithCustomerDto = await _roomService.IncreaseCapacityWhenDeletingCustomersAsync((int)customer.RoomId);

			Record record = _mapper.Map<Record>(customer);
			record.Id = 0;
			record.RoomName = roomWithCustomerDto.RoomName;
			await _recordService.AddAsync(record);

			await _customerService.RemoveAsync(customer);
			return RedirectToAction(nameof(Index));

		}
	}

}
