using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;


namespace Project.Service.Services
{
	public class AppUserService : Service<AppUser>, IAppUserService
	{
        private readonly IAppUserRepository _appUserRepository;
        private readonly IMapper _mapper;
		public AppUserService(IUnitOfWork unitOfWok, IGenericRepository<AppUser> repository, IAppUserRepository appUserRepository, IMapper mapper) : base(unitOfWok, repository)
		{
			_appUserRepository = appUserRepository;
			_mapper = mapper;
		}

		public async Task<ClaimsPrincipal> SignInAndCreateClaims(AppUserDto appUserDto)
		{
            AppUser appUser = _appUserRepository.Default(x => x.UserName == appUserDto.UserName);
            List<Claim> claims = new List<Claim>()
			{
				new Claim("userName",appUser.UserName),
				new Claim("userId",appUser.Id.ToString()),
				new Claim("role",appUser.Role.ToString())
			};

			ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
			return principal;

		}

		public async Task<bool> UserIsValid(AppUserDto appUserDto)
		{
			if (await _appUserRepository.AnyAsync(x=> x.UserName == appUserDto.UserName))
			{
				AppUser appUser = _appUserRepository.Default(x => x.UserName == appUserDto.UserName);
				bool isValid = BCrypt.Net.BCrypt.Verify(appUserDto.Password, appUser.Password);

				if (isValid)
				{
					return true;
				}
			}
			return false;
        }
	}
}
