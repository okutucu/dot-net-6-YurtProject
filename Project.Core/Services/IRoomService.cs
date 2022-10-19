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
        Task ReducingRoomCapacity(int roomId);
        Task<RoomUpdateDto> RoomCapacityAccuracy(RoomUpdateDto roomUpdateDto);
        Task GetCustomerWithRoomForRoomChange(int oldRoomId, int newRoomId);

        Task IncreaseCapacityWhenDeletingCustomers(int roomId);


    }
}
