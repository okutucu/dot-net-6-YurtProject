using Project.Core.Models;

namespace Project.Core.Services
{
	public interface IRecordService : IService<Record>
	{
		Task AddByDeletingCustomer(string roomName);
	}
}
