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
    public class RecordService : Service<Record>, IRecordService
    {
        public RecordService(IUnitOfWork unitOfWok, IGenericRepository<Record> repository) : base(unitOfWok, repository)
        {
        }
    }
}
