using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class RoomTypeService : Service<RoomType>, IRoomTypeService
    {
        public RoomTypeService(IUnitOfWork unitOfWok, IGenericRepository<RoomType> repository) : base(unitOfWok, repository)
        {
        }
    }
}
