using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IIncomeDetailService : IService<IncomeDetail>
	{
        Task<List<IncomeDetailDto>> GetIncomeWithRoomAsync();
        Task AddByCurrency(IncomeDetailDto incomeDetailDto, decimal currency);
        Task UpdateByCurrency(IncomeDetailDto incomeDetailDto, decimal currency);
        Task<List<IncomeDetailDto>> DailyOrMonthly(string selectedDate);
        Task<List<IncomeDetailDto>> GetByMonth(int year, int month);
        Task<List<IncomeDetailDto>> GetByDay(int year, int month, int day);

    }
}
