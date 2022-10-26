using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IRoomIncomeService : IService<RoomIncome>
    {
        Task AddByCurrency(RoomIncomeDto roomIncomeDto, decimal currency);
        Task UpdateByCurrency(RoomIncomeDto roomIncomeDto, decimal currency);
        Task<List<RoomIncomeWithRoomDto>> GetByMonth(DateTime selectedDate);

    }
}
