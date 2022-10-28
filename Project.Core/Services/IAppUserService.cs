using System.Security.Claims;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IAppUserService : IService<AppUser>
	{
		Task<bool> UserIsValid(AppUserDto appUserDto);
		Task<ClaimsPrincipal> SignInAndCreateClaims(AppUserDto appUserDto);
	}
}
