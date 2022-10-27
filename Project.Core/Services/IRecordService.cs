using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IRecordService
    {
        IQueryable<Record> GetAll();
        Task<Record> AddAsync(Record record);
        Task RemoveAsync(Record record);
    }
}
