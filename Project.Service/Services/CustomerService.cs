using AutoMapper;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(IUnitOfWork unitOfWok, IGenericRepository<Customer> repository, ICustomerRepository customerRepository, IMapper mapper) : base(unitOfWok, repository)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
    }
}
