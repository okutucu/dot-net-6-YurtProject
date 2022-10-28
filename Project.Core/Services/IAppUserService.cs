using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IAppUserService : IService<AppUser>
	{
		Task<AppUserDto> UserIsValid();
	}
}
