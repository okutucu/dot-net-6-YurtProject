using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;

namespace Project.Service.Services
{
	public class RecordService : Service<Record>, IRecordService
	{
		private readonly IRecordRepository _recordRepository;

		public RecordService(IUnitOfWork unitOfWok, IGenericRepository<Record> repository, IRecordRepository recordRepository) : base(unitOfWok, repository)
		{
			_recordRepository = recordRepository;
		}

		public Task AddByDeletingCustomer(string roomName)
		{
			throw new NotImplementedException();
		}
	}
}
