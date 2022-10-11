using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IRoomService : IService<Room>
    {
        Task<List<RoomWithCustomerDto>> GetRoomWithCustomerAsync();
        Task<RoomWithCustomerDto> GetSingleRoomByIdWithCustomerAsync(int roomId);
        Task ReducingRoomCapacity(int roomId);
        Task<RoomDto> RoomCapacityAccuracy(int roomId, int Capacity);
        Task GetCustomerWithRoomForRoomChange(int oldRoomId, int newRoomId);

        Task IncreaseCapacityWhenDeletingCustomers(int roomId);


    }
}
