using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;

namespace Project.Core.Repositories
{
	public interface IIncomeDetailRepository : IGenericRepository<IncomeDetail>
	{
        Task<List<IncomeDetail>> GetIncomeWithRoomAsync();

    }
}
