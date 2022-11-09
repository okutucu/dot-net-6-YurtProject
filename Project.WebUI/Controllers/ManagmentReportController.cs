using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.Controllers
{
	public class ManagmentReportController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
