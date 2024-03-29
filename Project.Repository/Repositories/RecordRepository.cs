﻿using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
	public class RecordRepository : GenericRepository<Record>, IRecordRepository
	{
		public RecordRepository(YurtDbContext context) : base(context)
		{
		}
	}
}
