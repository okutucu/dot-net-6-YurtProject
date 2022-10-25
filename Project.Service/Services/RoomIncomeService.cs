using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class RoomIncomeService : Service<RoomIncome>, IRoomIncomeService
    {
        public RoomIncomeService(IUnitOfWork unitOfWok, IGenericRepository<RoomIncome> repository) : base(unitOfWok, repository)
        {
        }

        public Task AddByCurrency(RoomIncomeDto roomIncomeDto, decimal currency)
        {
            throw new NotImplementedException();
        }

        public Task UpdateByCurrency(RoomIncomeDto roomIncomeDto, decimal currency)
        {
            throw new NotImplementedException();
        }
    }
}
