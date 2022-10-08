using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class RoomService : Service<Room>, IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IUnitOfWork unitOfWok, IGenericRepository<Room> repository, IMapper mapper, IRoomRepository roomRepository) : base(unitOfWok, repository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
        }

        public async Task<List<RoomWithCustomerDto>> GetRoomWithCustomerAsync()
        {
            List<Room> rooms = await _roomRepository.GetRoomWithCustomerAsync();

            List<RoomWithCustomerDto> roomDto = _mapper.Map<List<RoomWithCustomerDto>>(rooms);

            return roomDto;

        }

        public async Task<RoomWithCustomerDto> GetSingleRoomByIdWithCustomerAsync(int roomId)
        {
            Room room = await _roomRepository.GetSingleRoomByIdWithCustomerAsync(roomId);

            RoomWithCustomerDto roomDto = _mapper.Map<RoomWithCustomerDto>(room);

            return roomDto;
        }
    }
}
