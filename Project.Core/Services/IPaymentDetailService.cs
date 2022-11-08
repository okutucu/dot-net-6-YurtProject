using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IPaymentDetailService : IService<PaymentDetail>
	{
        Task<List<PaymentDetailWithRoomDto>> GetPaymentWithSingleRoomIdAsync(int roomId, DateTime selectedDate);
        Task<List<PaymentDetailWithRoomDto>> GetPaymentWithRoomAsync();
        Task AddByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
		Task UpdateByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
		Task<List<PaymentDetailWithRoomDto>> DailyOrMonthly(string selectedDate);
		Task<List<PaymentDetailWithRoomDto>> GetByMonth(int year, int month);
		Task<List<PaymentDetailWithRoomDto>> GetByDay(int year, int month, int day);
       

    }
}
