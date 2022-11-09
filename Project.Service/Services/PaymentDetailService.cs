using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;
using Project.Repository.Repositories;

namespace Project.Service.Services
{
	public class PaymentDetailService : Service<PaymentDetail>, IPaymentDetailService
	{
		private readonly IPaymentDetailRepository _paymentDetailRepository;
		private readonly IMapper _mapper;
		public PaymentDetailService(IUnitOfWork unitOfWok, IGenericRepository<PaymentDetail> repository, IPaymentDetailRepository paymentDetailRepository, IMapper mapper) : base(unitOfWok, repository)
		{
			_paymentDetailRepository = paymentDetailRepository;
			_mapper = mapper;
		}

		public async Task AddByCurrency(PaymentDetailDto paymentDetailDto, decimal currency)
		{

			paymentDetailDto.MoneyOfTheDay = currency * paymentDetailDto.Price;
			paymentDetailDto.PaymentDate = DateTime.Now;

			await _paymentDetailRepository.AddAsync(_mapper.Map<PaymentDetail>(paymentDetailDto));
			await _unitOfWok.CommitAsync();


		}
		public async Task UpdateByCurrency(PaymentDetailDto paymentDetailDto, decimal currency)
		{
			paymentDetailDto.MoneyOfTheDay = currency * paymentDetailDto.Price;
			//todo control
			paymentDetailDto.PaymentDate = DateTime.Now;


			_paymentDetailRepository.Update(_mapper.Map<PaymentDetail>(paymentDetailDto));
			await _unitOfWok.CommitAsync();
		}

		public async Task<List<PaymentDetailWithRoomDto>> DailyOrMonthly(string selectedDate)
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

		public async Task<List<PaymentDetailWithRoomDto>> GetByMonth(int year, int month)
		{

			List<PaymentDetail> paymentDetails = await _paymentDetailRepository.GetPaymentWithRoomAsync();
			List<PaymentDetail> paymentFilters = paymentDetails.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month).ToList();

			List<PaymentDetailWithRoomDto> paymentDetailWithRoomDtos = _mapper.Map<List<PaymentDetailWithRoomDto>>(paymentFilters);

			return paymentDetailWithRoomDtos;
		}

		public async Task<List<PaymentDetailWithRoomDto>> GetByDay(int year, int month, int day)
		{
            List<PaymentDetail> paymentDetails = await _paymentDetailRepository.GetPaymentWithRoomAsync();
            List<PaymentDetail> paymentFilters = paymentDetails.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month && p.PaymentDate.Day == day).ToList();

            List<PaymentDetailWithRoomDto> paymentDetailWithRoomDtos = _mapper.Map<List<PaymentDetailWithRoomDto>>(paymentFilters);

            return paymentDetailWithRoomDtos;
		}

		public async Task<List<PaymentDetailWithRoomDto>> GetPaymentWithSingleRoomIdAsync(int roomId, DateTime selectedDate)
		{
			List<PaymentDetailWithRoomDto> paymentDetailWithRoom = await GetPaymentWithRoomAsync();

            List<PaymentDetailWithRoomDto> paymentDetailWithRoomDto = paymentDetailWithRoom.Where(i => i.RoomId == roomId && i.PaymentDate.Month == selectedDate.Month && i.PaymentDate.Year == selectedDate.Year).ToList();
            return paymentDetailWithRoomDto;

        }

		public async Task<List<PaymentDetailWithRoomDto>> GetPaymentWithRoomAsync()
		{
            List<PaymentDetail> paymentDetails = await _paymentDetailRepository.GetPaymentWithRoomAsync();

            List<PaymentDetailWithRoomDto> paymentDetailsDto = _mapper.Map<List<PaymentDetailWithRoomDto>>(paymentDetails);

            return paymentDetailsDto;
        }

		public async Task<List<PaymentDetailWithRoomDto>> GetByYear(int year)
		{
            List<PaymentDetail> paymentDetails = await _paymentDetailRepository.GetPaymentWithRoomAsync();
            List<PaymentDetail> paymentFilters = paymentDetails.Where(p => p.PaymentDate.Year == year).ToList();

            List<PaymentDetailWithRoomDto> paymentDetailWithRoomDtos = _mapper.Map<List<PaymentDetailWithRoomDto>>(paymentFilters);

            return paymentDetailWithRoomDtos;
        }
	}
}
