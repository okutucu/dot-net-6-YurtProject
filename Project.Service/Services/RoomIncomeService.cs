using System;
using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;
using Project.Repository.Repositories;

namespace Project.Service.Services
{
	public class RoomIncomeService : Service<RoomIncome>, IRoomIncomeService
	{
		private readonly IRoomIncomeRepository _roomIncomeRepository;
		private readonly IMapper _mapper;
		public RoomIncomeService(IUnitOfWork unitOfWok, IGenericRepository<RoomIncome> repository, IRoomIncomeRepository roomIncomeRepository, IMapper mapper) : base(unitOfWok, repository)
		{
			_roomIncomeRepository = roomIncomeRepository;
			_mapper = mapper;
		}

		public async Task AddByCurrency(RoomIncomeDto roomIncomeDto, decimal currency)
		{
			roomIncomeDto.MoneyOfTheDay = currency * roomIncomeDto.Price;
			roomIncomeDto.PaymentDate = DateTime.Now;


			await _roomIncomeRepository.AddAsync(_mapper.Map<RoomIncome>(roomIncomeDto));
			await _unitOfWok.CommitAsync();
		}
        public async Task UpdateByCurrency(RoomIncomeDto roomIncomeDto, decimal currency)
        {
            roomIncomeDto.MoneyOfTheDay = currency * roomIncomeDto.Price;
            roomIncomeDto.PaymentDate = DateTime.Now;

            _roomIncomeRepository.Update(_mapper.Map<RoomIncome>(roomIncomeDto));
            await _unitOfWok.CommitAsync();
        }

		public async Task<RoomIncomeWithRoomDto> GetIncomeWithSingleRoomAsync(int roomIncomeId)
		{
			RoomIncome roomIncome = await _roomIncomeRepository.GetIncomeWithSingleRoomAsync(roomIncomeId);

			RoomIncomeWithRoomDto roomIncomeWithRoomDto = _mapper.Map<RoomIncomeWithRoomDto>(roomIncome);

			return roomIncomeWithRoomDto;
		}

		public async Task<List<RoomIncomeWithRoomDto>> DailyOrMonthly(string selectedDate)
		{
            if (selectedDate != null)
            {
                int month;
                int year;
                string[] subs = selectedDate.Split('-');

                if (subs.Length == 1)
                {
                    year = int.Parse(subs[0]);
                    return await GetByYear(year);
                }
                else if (subs.Length == 2)
                {
                    year = int.Parse(subs[0]);
                    month = int.Parse(subs[1]);

                    return await GetByMonth(year, month);
                }
                else if (subs.Length == 3)
                {
                    year = int.Parse(subs[0]);
                    month = int.Parse(subs[1]);
                    int day = int.Parse(subs[2].Substring(0, 2));

                    return await GetByDay(year, month, day);

                }
            }

            throw new Exception("An error occurred in the date format");
        }

		public async Task<List<RoomIncomeWithRoomDto>> GetByMonth(int year, int month)
		{
            List<RoomIncome> roomIncomes = await _roomIncomeRepository.GetIncomeWithRoomAsync();
            List<RoomIncome> roomIncomeFilters = roomIncomes.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month).ToList();

            List<RoomIncomeWithRoomDto> incomeDetailWithRoomDtos = _mapper.Map<List<RoomIncomeWithRoomDto>>(roomIncomeFilters);

            return incomeDetailWithRoomDtos;
        }

		public async Task<List<RoomIncomeWithRoomDto>> GetByDay(int year, int month, int day)
		{
            List<RoomIncome> roomIncomes = await _roomIncomeRepository.GetIncomeWithRoomAsync();
            List<RoomIncome> roomIncomeFilters = roomIncomes.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month && p.PaymentDate.Day == day).ToList();

            List<RoomIncomeWithRoomDto> incomeDetailWithRoomDtos = _mapper.Map<List<RoomIncomeWithRoomDto>>(roomIncomeFilters);

            return incomeDetailWithRoomDtos;
        }

        public async Task<List<RoomIncomeWithRoomDto>> GetRoomIncomeWithSingleRoomIdAsync(int roomId, DateTime selectedDate)
        {
            List<RoomIncomeWithRoomDto> roomIncomesWithRoom = await GetRoomIncomeWithRoomAsync();

            List<RoomIncomeWithRoomDto> roomIncomesWithRoomDto = roomIncomesWithRoom.Where(i => i.RoomId == roomId && i.PaymentDate.Month == selectedDate.Month && i.PaymentDate.Year == selectedDate.Year).ToList();
            return roomIncomesWithRoomDto;
        }

        public async Task<List<RoomIncomeWithRoomDto>> GetRoomIncomeWithRoomAsync()
        {
            List<RoomIncome> roomIncomes = await _roomIncomeRepository.GetIncomeWithRoomAsync();

            List<RoomIncomeWithRoomDto> roomIncomesDto = _mapper.Map<List<RoomIncomeWithRoomDto>>(roomIncomes);

            return roomIncomesDto;
        }

        public async Task<List<RoomIncomeWithRoomDto>> GetByYear(int year)
        {
            List<RoomIncome> roomIncomes = await _roomIncomeRepository.GetIncomeWithRoomAsync();
            List<RoomIncome> roomIncomeFilters = roomIncomes.Where(p => p.PaymentDate.Year == year).ToList();

            List<RoomIncomeWithRoomDto> incomeDetailWithRoomDtos = _mapper.Map<List<RoomIncomeWithRoomDto>>(roomIncomeFilters);

            return incomeDetailWithRoomDtos;
        }
    }
}
