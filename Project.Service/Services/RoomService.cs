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

        public async Task GetCustomerWithRoomForRoomChange(int oldRoomId, int newRoomId)
        {
            RoomWithCustomerDto newRoom = await GetSingleRoomByIdWithCustomerAsync(newRoomId);
            RoomWithCustomerDto oldRoom = await GetSingleRoomByIdWithCustomerAsync(oldRoomId);

            //Room newRoom = await _roomRepository.GetByIdAsync(newRoomId);
            //Room oldRoom = await _roomRepository.GetByIdAsync(oldRoomId);

            int newRoomCustomerCount = newRoom.Customers.Count();
            int oldRoomCustomerCount = oldRoom.Customers.Count();

            if (newRoomCustomerCount == 0)
            {
                if(oldRoomCustomerCount > 1)
                {
                    oldRoom.Price -= 400;
                }

                newRoom.Debt = newRoom.Price;
            }
            else
            {
                if (oldRoomCustomerCount > 1)
                {
                    oldRoom.Price -= 400;
                }
                newRoom.Debt += 400;
                newRoom.Price += 400;
            }

            oldRoom.CurrentCapacity++;
            newRoom.CurrentCapacity--;

            _roomRepository.Update(_mapper.Map<Room>(oldRoom));
            _roomRepository.Update(_mapper.Map<Room>(newRoom));
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

        public async Task IncreaseCapacityWhenDeletingCustomers(int roomId)
        {
            RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomId);
            int customerCount = roomAndCustomerDto.Customers.Count();

            if (customerCount > 1)
            {
                roomAndCustomerDto.Price -= 400;
            }

            roomAndCustomerDto.CurrentCapacity++;


            _roomRepository.Update(_mapper.Map<Room>(roomAndCustomerDto));
        }

        public async Task ReducingRoomCapacity(int roomId)
        {
            RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomId);
            Room room = await _roomRepository.ReducingRoomCapacity(roomId);
            int customerCount = roomAndCustomerDto.Customers.Count();

            if(customerCount == 0)
            {
                room.Debt  = roomAndCustomerDto.Price;
                room.CurrentCapacity--;
                await _unitOfWok.CommitAsync();
                return;
            }
            else if(customerCount > 0)
            {
                room.Price += 400;
                room.Debt += 400;
                room.CurrentCapacity--;
                await _unitOfWok.CommitAsync();
                return;
            }
        }

        public async Task<RoomUpdateDto> RoomCapacityAccuracy(RoomUpdateDto roomUpdateDto)
        {

            RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomUpdateDto.Id);
            Room room = await _roomRepository.RoomCapacityAccuracy(roomUpdateDto.Id);
            roomUpdateDto.Debt = room.Debt;

            int customerCount = roomAndCustomerDto.Customers.Count();

            //todo tracking
            //todo update room properties
            //todo sero
            
            if (roomUpdateDto.Capacity >= customerCount)
            {
                if (room.CurrentCapacity == room.Capacity)
                {
                    roomUpdateDto.CurrentCapacity = roomUpdateDto.Capacity;
                    return roomUpdateDto;
                }
                else
                {
                    room.CurrentCapacity += (roomUpdateDto.Capacity - room.Capacity);
                    roomUpdateDto.CurrentCapacity = room.CurrentCapacity;
                    return roomUpdateDto;
                }
            }
            else
            {
                throw new Exception("Room capacity cannot be less than the number of customers in the room.");
            }


        }
    }
}
