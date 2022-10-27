using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface IRecordRepository
    {
        IQueryable<Record> GetAll();
        Task AddAsync(Record record);
        void Remove(Record record);
    }
}
