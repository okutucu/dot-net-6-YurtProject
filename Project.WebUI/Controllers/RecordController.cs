using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    [Authorize(Policy = "SuperAdminPolicy")]
    public class RecordController : Controller
	{
		private readonly IRecordService _recordService;
		private readonly IMapper _mapper;

		public RecordController(IRecordService recordService, IMapper mapper)
		{
			_recordService = recordService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			List<Record> records = _recordService.GetAll().ToList();
			List<RecordDto> recordsDto = _mapper.Map<List<RecordDto>>(records);
			return View(recordsDto);
		}

		[ServiceFilter(typeof(NotFoundFilter<Record>))]
		public async Task<IActionResult> Detail(int id)
		{
			Record record = await _recordService.GetByIdAsync(id);
			RecordDto recordDto = _mapper.Map<RecordDto>(record);
			return View(recordDto);
		}



		[ServiceFilter(typeof(NotFoundFilter<Record>))]
		public async Task<IActionResult> Remove(int id)
		{
			Record record = await _recordService.GetByIdAsync(id);
			await _recordService.RemoveAsync(record);
			return RedirectToAction(nameof(Index));
		}
	}
}
