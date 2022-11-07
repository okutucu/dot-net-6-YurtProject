using Project.Core.Models;

namespace Project.Core.Repositories
{
	public interface IPaymentDetailRepository : IGenericRepository<PaymentDetail>
	{
        Task<List<PaymentDetail>> GetPaymentWithRoomAsync();

    }
}
