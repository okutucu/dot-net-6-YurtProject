using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class MailController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMailService _mailService;
        private readonly IMapper _mapper;

        public MailController(ICustomerService customerService, IMailService mailService, IMapper mapper)
        {
            _customerService = customerService;
            _mailService = mailService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendAMailToTheDebtors(MailDto mailDto)
        {
            if (ModelState.IsValid)
            {
                List<string> customers = await _customerService.Where(x => x.Room.Debt > 0).Select(x => x.Email).ToListAsync();
                await _mailService.SendAMailToCondition(customers, mailDto);
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index),mailDto);
        }

        [HttpPost]
        public async Task<IActionResult> SendAMailToAllUsers(MailDto mailDto)
        {
            if (ModelState.IsValid)
            {
                List<string> customers = await _customerService.GetAll().Select(x => x.Email).ToListAsync();
                await _mailService.SendAMailToCondition(customers, mailDto);
                return RedirectToAction(nameof(Index));

            }

            return View(nameof(Index), mailDto);
        }

    }
}
