using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;

namespace Project.WebUI.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(AppUserDto appUserDto)
		{
			return View();
		}
	}
}
