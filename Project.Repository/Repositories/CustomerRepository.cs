using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(YurtDbContext context) : base(context)
        {
        }

        public async Task<Customer> GetCustomerWithRoomForRoomChange(int customerId)
        {
            return await _context.Customers.Include(c => c.Room).Where(c => c.Id == customerId).AsNoTracking().SingleOrDefaultAsync();
        }

        public async Task<List<Customer>> GetCustomerWithRoomAsync()
        {
            return await _context.Customers.Include(c => c.Room).ToListAsync();

        }
    }
}
