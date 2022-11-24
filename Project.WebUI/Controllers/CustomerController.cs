using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.Service.Utilities.Extensions;

namespace Project.WebUI.Controllers
{
    [Authorize]
    public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;
		private readonly IRecordService _recordService;
        private readonly IWebHostEnvironment _env;

		public CustomerController(ICustomerService customerService, IMapper mapper, IRoomService roomService, IRecordService recordService, IWebHostEnvironment env)
		{
			_customerService = customerService;
			_mapper = mapper;
			_roomService = roomService;
			_recordService = recordService;
			_env = env;
		}
		public async Task<IActionResult> Index()
		{
            return View(await _customerService.GetCustomerWithRoomAsync());
		}

        public async Task<IActionResult> Detail(int id)
        {
            CustomerWithImagesDto customer = await _customerService.GetSingleCustomeByIdWithImagesAsync(id);
            return View(customer);
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
				if (customerDto.Files != null)
				{
                   await ImageUpload(customerDto, customerDto.Files, "CustomerImages");
                }
				await _roomService.ReducingRoomCapacityAsync(customerDto.RoomId);

				await _customerService.AddAsync(_mapper.Map<Customer>(customerDto));

				return RedirectToAction(nameof(Index));
			}

			List<Room> rooms = _roomService.Where(r => r.CurrentCapacity > 0).ToList();

			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);

			ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

			return View(customerDto);
		}

		public async Task<IList<CustomerImage>> ImageUpload(CustomerDto customerDto,IFormFile[] formFiles, string folderName)
		{
			string filePath = Path.Combine($"{_env.WebRootPath}/img", folderName);
			if (!Directory.Exists(filePath))
			{
				Directory.CreateDirectory(filePath);
			}

			foreach (IFormFile item in formFiles)
			{
				string fileExtension = Path.GetExtension(item.FileName);
				DateTime dateTime = DateTime.Now;
				string fullFileName = $"{item.FileName}_{dateTime.FullDateAndtimeStringWithUnderscore()}{fileExtension}";

				string path = Path.Combine(filePath, fullFileName);

				using (FileStream fileFlow = new FileStream(path, FileMode.Create))
				{
					await item.CopyToAsync(fileFlow);
				}
				 
                customerDto.CustomerImages.Add(new CustomerImage { FileName = fullFileName });
			}

			return customerDto.CustomerImages;
		}

		public bool ImageDelete(IList<CustomerImage> pictureNames, string folderName)
		{
            string filePath = Path.Combine($"{_env.WebRootPath}/img", folderName);

            int counter = 0;

            foreach (var item in pictureNames)
			{
                string path = Path.Combine(filePath, item.FileName);

                if (System.IO.File.Exists(path))
				{
					System.IO.File.Delete(path);
					counter++;
                }
			}

			if (counter != 0)
			{
				return true;
			}
			else
			{
				return false;
			}
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
                CustomerWithImagesDto customer = await _customerService.GetSingleCustomeByIdWithImagesAsync(customerDto.Id);

                bool isNewPictureUploaded = false;
				IList<CustomerImage> oldCustomerPictures = customer.CustomerImages;

				if (customerDto.Files != null)
				{
                    customerDto.CustomerImages = await ImageUpload(customerDto, customerDto.Files, "CustomerImages");
					isNewPictureUploaded = true;
                }

                if (customerDto.RoomId == customer.RoomId)
				{
					await _customerService.UpdateAsync(_mapper.Map<Customer>(customerDto));
				}
				else
				{
					await _roomService.GetCustomerWithRoomForRoomChangeAsync((int)customer.RoomId, customerDto.RoomId);
					await _customerService.UpdateAsync(_mapper.Map<Customer>(customerDto));
				}


				if (isNewPictureUploaded)
				{
					ImageDelete(oldCustomerPictures, "CustomerImages");
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
