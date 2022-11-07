using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

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
			paymentDetailDto.PaymentDate = DateTime.Now;


			_paymentDetailRepository.Update(_mapper.Map<PaymentDetail>(paymentDetailDto));
			await _unitOfWok.CommitAsync();
		}



		public async Task<List<PaymentDetailDto>> DailyOrMonthly(string selectedDate)
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

		public async Task<List<PaymentDetailDto>> GetByMonth(int year, int month)
		{
			List<PaymentDetail> paymentDetails = _paymentDetailRepository.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month).ToList();

			List<PaymentDetailDto> paymentDetailsDto = _mapper.Map<List<PaymentDetailDto>>(paymentDetails);

			return paymentDetailsDto;
		}

		public async Task<List<PaymentDetailDto>> GetByDay(int year, int month, int day)
		{
			List<PaymentDetail> paymentDetails = _paymentDetailRepository.Where(p => p.PaymentDate.Year == year && p.PaymentDate.Month == month && p.PaymentDate.Day == day).ToList();

			List<PaymentDetailDto> paymentDetailsDto = _mapper.Map<List<PaymentDetailDto>>(paymentDetails);

			return paymentDetailsDto;
		}

		public Task<List<PaymentDetailDto>> GetPaymentWithSingleRoomIdAsync(int roomId)
		{
			throw new NotImplementedException();
		}
	}
}
