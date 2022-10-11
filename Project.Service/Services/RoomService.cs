using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
            RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(newRoomId);

            Room newRoom = await _roomRepository.GetByIdAsync(newRoomId);
            Room oldRoom = await _roomRepository.GetByIdAsync(oldRoomId);


            int customerCount = roomAndCustomerDto.Customers.Count();


            if (customerCount == 0)
            {
                newRoom.Debt = roomAndCustomerDto.Price;
                oldRoom.CurrentCapacity++;
                newRoom.CurrentCapacity--;
                oldRoom.Price -= 400;
            }

            //todo remove and update dept price kontrol edilecek
            else
            {
                newRoom.Debt += 400;
                newRoom.Price += 400;
                oldRoom.CurrentCapacity++;
                newRoom.CurrentCapacity--;
            }          
            _roomRepository.Update(oldRoom);
            _roomRepository.Update(newRoom);
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

            Room room = await _roomRepository.GetByIdAsync(roomId);


            if (customerCount >= 1)
            {
                room.Price -= 400;
                room.Debt -= 400;
                room.CurrentCapacity++;
            }



            _roomRepository.Update(room);
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

        public async Task<RoomDto> RoomCapacityAccuracy(int roomId, int Capacity)
        {

            RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomId);
            Room room = await _roomRepository.RoomCapacityAccuracy(roomId);

            RoomDto roomDto = _mapper.Map<RoomDto>(room);

            int customerCount = roomAndCustomerDto.Customers.Count();

            //todo tracking

            if (Capacity >= customerCount)
            {
                if (roomDto.CurrentCapacity == roomDto.Capacity)
                {
                    roomDto.Capacity = Capacity;
                    roomDto.CurrentCapacity = Capacity;
                    return roomDto;
                }
                else
                {
                    roomDto.CurrentCapacity += (Capacity - room.Capacity);
                    roomDto.Capacity = Capacity;
                    return roomDto;
                }
            }
            else
            {
                throw new Exception("Room capacity cannot be less than the number of customers in the room.");
            }


        }
    }
}
