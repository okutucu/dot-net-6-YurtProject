using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        protected readonly YurtDbContext _context;
        private readonly DbSet<Record> _dbSet;


        public RecordRepository(YurtDbContext context, DbSet<Record> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public async Task AddAsync(Record record)
        {
            await _dbSet.AddAsync(record);

        }

        public IQueryable<Record> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public void Remove(Record record)
        {
            _dbSet.Remove(record);
        }
    }
}
