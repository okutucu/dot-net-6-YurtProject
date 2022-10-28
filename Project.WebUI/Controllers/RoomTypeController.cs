using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
	public class RoomTypeController : Controller
	{
		private readonly IService<RoomType> _service;
		private readonly IMapper _mapper;


		public RoomTypeController(IService<RoomType> service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}


		public async Task<IActionResult> Index()
		{
			List<RoomType> roomsType = _service.GetAll().ToList();

			return View(_mapper.Map<List<RoomTypeDto>>(roomsType));
		}

		public IActionResult Create()
		{
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> Create(RoomTypeDto roomTypeDto)
		{
			if (ModelState.IsValid)
			{
				await _service.AddAsync(_mapper.Map<RoomType>(roomTypeDto));
				return RedirectToAction(nameof(Index));
			}
			return View(roomTypeDto);

		}
		[ServiceFilter(typeof(NotFoundFilter<RoomType>))]
		public async Task<IActionResult> Update(int id)
		{
			RoomType roomType = await _service.GetByIdAsync(id);
			return View(_mapper.Map<RoomTypeDto>(roomType));
		}

		[HttpPost]
		public async Task<IActionResult> Update(RoomTypeDto roomTypeDto)
		{
			if (ModelState.IsValid)
			{
				await _service.UpdateAsync(_mapper.Map<RoomType>(roomTypeDto));
				return RedirectToAction(nameof(Index));
			}
			return View(roomTypeDto);
		}

		public async Task<IActionResult> Remove(int id)
		{
			RoomType roomType = await _service.GetByIdAsync(id);

			await _service.RemoveAsync(roomType);
			return RedirectToAction(nameof(Index));

		}
	}
}
