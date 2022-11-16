using System;
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
		public async Task ChangeRoomIncomesByRoomIncomesAsync(RoomIncomeWithRoomDto roomIncomeWithRoomDto, int newRoomId, decimal currency, decimal price)
		{
			Room oldRoom = await _roomRepository.GetByIdAsync(roomIncomeWithRoomDto.RoomId);
			Room newRoom = await _roomRepository.GetByIdAsync(newRoomId);
			if (oldRoom.Id == newRoom.Id)
			{
				oldRoom.Debt += roomIncomeWithRoomDto.MoneyOfTheDay;
				oldRoom.Debt -= currency * price;
				_roomRepository.Update(_mapper.Map<Room>(oldRoom));
			}
			else
			{
				oldRoom.Debt += roomIncomeWithRoomDto.MoneyOfTheDay;
				newRoom.Debt -= currency * price;
				_roomRepository.Update(_mapper.Map<Room>(oldRoom));
				_roomRepository.Update(_mapper.Map<Room>(newRoom));
			}
		}
		public async Task GetCustomerWithRoomForRoomChangeAsync(int oldRoomId, int newRoomId)
		{
			RoomWithCustomerDto newRoom = await GetSingleRoomByIdWithCustomerAsync(newRoomId);
			RoomWithCustomerDto oldRoom = await GetSingleRoomByIdWithCustomerAsync(oldRoomId);

			RoomTypeWithRoomDto newRoomTypeWithRoom = await GetSingleRoomByIdWithRoomTypeAsync(newRoomId);

			int newRoomCustomerCount = newRoom.Customers.Count();

			if (newRoomCustomerCount > 0)
			{
				newRoom.Debt += newRoomTypeWithRoom.RoomType.IncreasedPrice;
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

		public async Task<List<RoomWithImageDto>> GetRoomWithImagesAsync(int roomId)
		{
            List<Room> rooms = await _roomRepository.GetRoomWithImagesAsync(roomId);

            List<RoomWithImageDto> roomsDto = _mapper.Map<List<RoomWithImageDto>>(rooms);

            return roomsDto;
        }

		public async Task<List<RoomTypeWithRoomDto>> GetRoomWithRoomTypeAsync()
		{
			List<Room> rooms = await _roomRepository.GetRoomWithRoomTypeAsync();

			List<RoomTypeWithRoomDto> roomTypeWithRoomDto = _mapper.Map<List<RoomTypeWithRoomDto>>(rooms);

			return roomTypeWithRoomDto;
		}
		public async Task<RoomWithCustomerDto> GetSingleRoomByIdWithCustomerAsync(int roomId)
		{
			Room room = await _roomRepository.GetSingleRoomByIdWithCustomerAsync(roomId);

			RoomWithCustomerDto roomDto = _mapper.Map<RoomWithCustomerDto>(room);

			return roomDto;
		}
		public async Task<RoomTypeWithRoomDto> GetSingleRoomByIdWithRoomTypeAsync(int roomId)
		{
			Room room = await _roomRepository.GetSingleRoomByIdWithRoomTypeAsync(roomId);

			RoomTypeWithRoomDto roomTypeDto = _mapper.Map<RoomTypeWithRoomDto>(room);

			return roomTypeDto;
		}
		public async Task<RoomWithCustomerDto> IncreaseCapacityWhenDeletingCustomersAsync(int roomId)
		{
			RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomId);
			roomAndCustomerDto.CurrentCapacity++;
			_roomRepository.Update(_mapper.Map<Room>(roomAndCustomerDto));

			return roomAndCustomerDto;
		}
		public async Task IncreaseRoomDebtWhenDeletingIncomesAsync(int roomId, decimal moneyOfTheDay)
		{
			Room room = await _roomRepository.GetByIdAsync(roomId);

			room.Debt += moneyOfTheDay;
			_roomRepository.Update(room);

		}
		public async Task ReduceDeptAsync(int roomId, decimal price, decimal currency)
		{
			Room room = await _roomRepository.GetByIdAsync(roomId);
			room.Debt -= (price * currency);

			_roomRepository.Update(room);

		}
		public async Task ReducingRoomCapacityAsync(int roomId)
		{
			RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomId);

			RoomTypeWithRoomDto roomTypeWithRoom = await GetSingleRoomByIdWithRoomTypeAsync(roomId);


			Room room = await _roomRepository.ReducingRoomCapacity(roomId);
			int customerCount = roomAndCustomerDto.Customers.Count();

			if (customerCount == 0)
			{
				room.Debt = roomTypeWithRoom.RoomType.Price;
				room.CurrentCapacity--;
				await _unitOfWok.CommitAsync();
				return;
			}
			else if (customerCount > 0)
			{
				room.Debt = roomTypeWithRoom.RoomType.Price;
				room.Debt += roomTypeWithRoom.RoomType.IncreasedPrice;
				room.CurrentCapacity--;
				await _unitOfWok.CommitAsync();
				return;
			}
		}
		public async Task<RoomUpdateDto> RoomCapacityAccuracyAsync(RoomUpdateDto roomUpdateDto)
		{

			RoomWithCustomerDto roomAndCustomerDto = await GetSingleRoomByIdWithCustomerAsync(roomUpdateDto.Id);
			Room room = await _roomRepository.RoomCapacityAccuracy(roomUpdateDto.Id);
			roomUpdateDto.Debt = room.Debt;

			int customerCount = roomAndCustomerDto.Customers.Count();

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
