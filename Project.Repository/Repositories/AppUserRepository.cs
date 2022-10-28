using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
	public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
	{
		public AppUserRepository(YurtDbContext context) : base(context)
		{
		}
	}
}
