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
        Task<RoomTypeWithRoomDto> GetSingleRoomByIdWithRoomIncomesAsync(int roomId);
        Task ReducingRoomCapacityAsync(int roomId);
        Task<RoomUpdateDto> RoomCapacityAccuracyAsync(RoomUpdateDto roomUpdateDto);
        Task GetCustomerWithRoomForRoomChangeAsync(int oldRoomId, int newRoomId);
        Task IncreaseCapacityWhenDeletingCustomersAsync(int roomId);
        Task ReduceDeptAsync(int roomId, decimal price, decimal currency);
        Task ChangeRoomIncomesByRoomIncomesAsync(int oldRoomId, int newRoomId, decimal currency, decimal price);



    }
}
