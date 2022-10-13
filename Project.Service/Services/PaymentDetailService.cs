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
    }
}
