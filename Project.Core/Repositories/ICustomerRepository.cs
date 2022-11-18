using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<List<Customer>> GetCustomerWithRoomAsync();
        Task<Customer> GetSingleCustomeByIdWithImagesAsync(int customerId);

    }
}
