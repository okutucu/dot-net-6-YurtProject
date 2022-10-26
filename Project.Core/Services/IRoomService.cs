using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IRoomService : IService<Room>
    {
        Task<List<RoomWithCustomerDto>> GetRoomWithCustomerAsync();
        Task<List<RoomTypeWithRoomDto>> GetRoomWithRoomTypeAsync();
        Task<RoomWithCustomerDto> GetSingleRoomByIdWithCustomerAsync(int roomId);
        Task<RoomTypeWithRoomDto> GetSingleRoomByIdWithRoomTypeAsync(int roomId);
        Task<RoomIncomeWithRoomDto> GetSingleRoomByIdWithRoomIncomesAsync(int roomId);
        Task ReducingRoomCapacityAsync(int roomId);
        Task<RoomUpdateDto> RoomCapacityAccuracyAsync(RoomUpdateDto roomUpdateDto);
        Task GetCustomerWithRoomForRoomChangeAsync(int oldRoomId, int newRoomId);
        Task IncreaseCapacityWhenDeletingCustomersAsync(int roomId);
        Task ReduceDeptAsync(int roomId, decimal price, decimal currency);
        Task ChangeRoomIncomesByRoomIncomesAsync(RoomIncomeWithRoomDto roomIncomeWithRoomDto, int newRoomId, ExchangeRate currency, decimal price);



    }
}
