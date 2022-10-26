using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public RoomIncomeService(IUnitOfWork unitOfWok, IGenericRepository<RoomIncome> repository, IRoomIncomeRepository roomIncomeRepository, IMapper mapper = null) : base(unitOfWok, repository)
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

        public async Task<List<RoomIncomeWithRoomDto>> GetByMonth(DateTime selectedDate)
        {

            int month = selectedDate.Month;
            int year = selectedDate.Year;

             List<RoomIncome> roomIncomes = await _roomIncomeRepository.GetIncomeWithRoomAsync();

            List<RoomIncome> roomDetails = roomIncomes.Where(r => r.PaymentDate.Year == year && r.PaymentDate.Month == month).ToList();

            List<RoomIncomeWithRoomDto> roomDetailsDto = _mapper.Map<List<RoomIncomeWithRoomDto>>(roomDetails);

            return roomDetailsDto;
        }



        public async Task UpdateByCurrency(RoomIncomeDto roomIncomeDto, decimal currency)
        {
            roomIncomeDto.MoneyOfTheDay = currency * roomIncomeDto.Price;
            roomIncomeDto.PaymentDate = DateTime.Now;

             _roomIncomeRepository.Update(_mapper.Map<RoomIncome>(roomIncomeDto));
            await _unitOfWok.CommitAsync();
        }
    }
}
