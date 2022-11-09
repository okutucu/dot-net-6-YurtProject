using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IIncomeDetailService : IService<IncomeDetail>
	{
        Task<List<IncomeWithRoomDto>> GetIncomeWithSingleRoomIdAsync(int roomId, DateTime selectedDate);
        Task<List<IncomeWithRoomDto>> GetIncomeWithRoomAsync();
		Task AddByCurrency(IncomeDetailDto incomeDetailDto, decimal currency);
		Task UpdateByCurrency(IncomeDetailDto incomeDetailDto, decimal currency);
		Task<List<IncomeWithRoomDto>> DailyOrMonthly(string selectedDate);
		Task<List<IncomeWithRoomDto>> GetByMonth(int year, int month);
		Task<List<IncomeWithRoomDto>> GetByYear(int year);
		Task<List<IncomeWithRoomDto>> GetByDay(int year, int month, int day);

	}
}
