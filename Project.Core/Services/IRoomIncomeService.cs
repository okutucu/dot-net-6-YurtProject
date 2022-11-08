using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IRoomIncomeService : IService<RoomIncome>
	{
        Task<RoomIncomeWithRoomDto> GetIncomeWithSingleRoomAsync(int roomIncomeId);

        Task AddByCurrency(RoomIncomeDto roomIncomeDto, decimal currency);
		Task UpdateByCurrency(RoomIncomeDto roomIncomeDto, decimal currency);
        Task<List<RoomIncomeWithRoomDto>> DailyOrMonthly(string selectedDate);
        Task<List<RoomIncomeWithRoomDto>> GetByMonth(int year, int month);
        Task<List<RoomIncomeWithRoomDto>> GetByDay(int year, int month, int day);
    }
}
