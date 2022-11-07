using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IPaymentDetailService : IService<PaymentDetail>
	{
		Task AddByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
		Task UpdateByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
		Task<List<PaymentDetailDto>> DailyOrMonthly(string selectedDate);
		Task<List<PaymentDetailDto>> GetByMonth(int year, int month);
		Task<List<PaymentDetailDto>> GetByDay(int year, int month, int day);
       

    }
}
