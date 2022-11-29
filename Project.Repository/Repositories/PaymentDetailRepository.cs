using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
	public class PaymentDetailRepository : GenericRepository<PaymentDetail>, IPaymentDetailRepository
	{
		public PaymentDetailRepository(YurtDbContext context) : base(context)
		{
		}

		public async Task<List<PaymentDetail>> GetPaymentWithRoomAsync()
		{
            return await _context.PaymentDetails.Include(i => i.PaymentName).Include(i => i.Room).ToListAsync();

        }
    }
}
