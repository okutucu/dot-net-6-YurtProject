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
  
		public async Task<List<PaymentDetail>> GetPaymentWithSingleRoomIdAsync(int roomId)
		{
			return await _context.PaymentDetails.Where(p => p.RoomId == roomId).Include(p => p.RoomId).ToListAsync();

		}
	}
}
