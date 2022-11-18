using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface ICustomerService : IService<Customer>
    {
        Task<List<CustomerListDto>> GetCustomerWithRoomAsync();

        Task<CustomerWithImagesDto> GetSingleCustomeByIdWithImagesAsync(int customerId);


    }
}
