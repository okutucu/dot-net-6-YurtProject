using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

 
        public async Task<IActionResult> Index()
        {
            return View(await _customerService.GetCustomerWithRoomAsync());
        }
    }
}
