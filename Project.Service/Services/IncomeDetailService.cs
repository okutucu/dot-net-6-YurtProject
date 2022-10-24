﻿using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class IncomeDetailService : Service<IncomeDetail>, IIncomeDetailService
	{
		private readonly IIncomeDetailRepository _incomeDetailRepository;
        private readonly IMapper _mapper;


		public IncomeDetailService(IUnitOfWork unitOfWok, IGenericRepository<IncomeDetail> repository, IIncomeDetailRepository incomeDetailRepository, IMapper mapper) : base(unitOfWok, repository)
		{
            _incomeDetailRepository = incomeDetailRepository;
            _mapper = mapper;
        }

		public async Task AddByCurrency(IncomeDetailDto incomeDetailDto, decimal currency)
		{
            incomeDetailDto.MoneyOfTheDay = currency * incomeDetailDto.Price;
            incomeDetailDto.PaymentDate = DateTime.Now;


            await _incomeDetailRepository.AddAsync(_mapper.Map<IncomeDetail>(incomeDetailDto));
            await _unitOfWok.CommitAsync();
        }

		public async Task<List<IncomeDetailDto>> DailyOrMonthly(string selectedDate)
		{
            if (selectedDate != null)
            {
                int month;
                int year;
                string[] subs = selectedDate.Split('-');

                if (subs.Length == 2)
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

		public async Task<List<IncomeDetailDto>> GetByDay(int year, int month, int day)
		{
            List<IncomeDetail> incomeDetails = _incomeDetailRepository.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month && p.PaymentDate.Day == day).ToList();

            List<IncomeDetailDto> incomeDetailDto = _mapper.Map<List<IncomeDetailDto>>(incomeDetails);

            return incomeDetailDto;
        }

		public async Task<List<IncomeDetailDto>> GetByMonth(int year, int month)
		{
            List<IncomeDetail> incomeDetails = _incomeDetailRepository.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month).ToList();

            List<IncomeDetailDto> incomeDetailDto = _mapper.Map<List<IncomeDetailDto>>(incomeDetails);

            return incomeDetailDto;
        }

		public async Task<List<IncomeDetailDto>> GetIncomeWithRoomAsync()
		{
			List<IncomeDetail> incomeDetails = await _incomeDetailRepository.GetIncomeWithRoomAsync();

			List<IncomeDetailDto> incomeDetailsDto = _mapper.Map<List<IncomeDetailDto>>(incomeDetails);

			return incomeDetailsDto;

        }

		public async Task UpdateByCurrency(IncomeDetailDto incomeDetailDto, decimal currency)
		{
            incomeDetailDto.MoneyOfTheDay = currency * incomeDetailDto.Price;
            incomeDetailDto.PaymentDate = DateTime.Now;


            _incomeDetailRepository.Update(_mapper.Map<IncomeDetail>(incomeDetailDto));
            await _unitOfWok.CommitAsync();
        }
	}
}