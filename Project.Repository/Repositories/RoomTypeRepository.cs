using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(YurtDbContext context) : base(context)
        {
        }
    }
}
