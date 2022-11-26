using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
    public class CustomerImageFileService : Service<CustomerImageFile>, ICustomerImageFileService
    {
        private readonly ICustomerImageFileRepository _customerImageFileRepository;

        public CustomerImageFileService(IUnitOfWork unitOfWok, IGenericRepository<CustomerImageFile> repository, ICustomerImageFileRepository customerImageFileRepository) : base(unitOfWok, repository)
        {
            _customerImageFileRepository = customerImageFileRepository;
        }
    }
}
