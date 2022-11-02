using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    public class MailController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMailService _mailService;

        public MailController(ICustomerService customerService, IMailService mailService)
        {
            _customerService = customerService;
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendAMailToTheDebtors(string subject, string body)
        {
            List<string> customers = await  _customerService.Where(x => x.Room.Debt >0).Select(x=> x.Email).ToListAsync();
            await _mailService.SendAMailToCondition(customers, subject, body);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> SendAMailToAllUsers(string subject, string body)
        {
            List<string> customers = await _customerService.GetAll().Select(x => x.Email).ToListAsync();
            await _mailService.SendAMailToCondition(customers, subject, body);

            return RedirectToAction(nameof(Index));
        }

    }
}
