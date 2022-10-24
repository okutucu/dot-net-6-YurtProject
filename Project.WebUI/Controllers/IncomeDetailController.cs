using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.Service.Services;

namespace Project.WebUI.Controllers
{
	public class IncomeDetailController : Controller
	{
		private readonly IIncomeDetailService _incomeDetailService;
        private readonly IMapper _mapper;

        public IncomeDetailController(IIncomeDetailService incomeDetailService, IMapper mapper)
		{
			_incomeDetailService = incomeDetailService;
			_mapper = mapper;
		}


		public async Task<IActionResult> Index()
		{
			List<IncomeDetail> incomeDetails = _incomeDetailService.GetAll().ToList();

			return View(_mapper.Map<List<IncomeDetailDto>>(incomeDetails));
		}


        public async Task<IActionResult> GetBySelected(string selectedDate)
		{
            return View();

        }
    }
}
