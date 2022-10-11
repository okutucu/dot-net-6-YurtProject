using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        Task<List<Room>> GetRoomWithCustomerAsync();
        Task<Room> GetSingleRoomByIdWithCustomerAsync(int roomId);
        Task<Room> ReducingRoomCapacity(int roomId);
        Task<Room> RoomCapacityAccuracy(int roomId);



    }
}
