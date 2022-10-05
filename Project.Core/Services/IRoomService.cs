using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IRoomService : IService<Room>
    {
        Task<List<RoomWithCustomerDto>> GetRoomWithCustomerAsync();
        Task<RoomWithCustomerDto> GetSingleRoomByIdWithCustomerAsync(int customerId);

    }
}
