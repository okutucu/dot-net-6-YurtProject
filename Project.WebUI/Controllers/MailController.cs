using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
