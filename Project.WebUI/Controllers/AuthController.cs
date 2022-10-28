
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{

	public class AuthController : Controller
	{
        private readonly IAppUserService _appUserService;

		public AuthController(IAppUserService appUserService)
		{
			_appUserService = appUserService;
		}
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(AppUserDto appUserDto)
		{
			if (ModelState.IsValid)
			{
				if (await _appUserService.UserIsValid(appUserDto))
				{
					ClaimsPrincipal principal = await _appUserService.SignInAndCreateClaims(appUserDto);
					await HttpContext.SignInAsync(principal);
					return RedirectToAction("Index", "Home");
                }
                return View(appUserDto);
            }
            return View(appUserDto);
		}

        [HttpGet]
        public ViewResult AccessDenied()
		{
			return View();
		}

		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Login");
		}
	}
}
