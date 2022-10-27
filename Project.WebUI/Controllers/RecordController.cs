using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
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
    }
}
