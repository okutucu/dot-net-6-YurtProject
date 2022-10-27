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
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        protected readonly IUnitOfWork _unitOfWok;


        public RecordService(IRecordRepository recordRepository, IUnitOfWork unitOfWok)
        {
            _recordRepository = recordRepository;
            _unitOfWok = unitOfWok;
        }

        public async Task<Record> AddAsync(Record record)
        {
            await _recordRepository.AddAsync(record);
            await _unitOfWok.CommitAsync();
            return record;
        }

        public async Task RemoveAsync(Record record)
        {
            _recordRepository.Remove(record);
            await _unitOfWok.CommitAsync();
        }

        public IQueryable<Record> GetAll()
        {
            return _recordRepository.GetAll();
        }
    }
}
