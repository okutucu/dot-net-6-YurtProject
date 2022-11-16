using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;

namespace Project.Repository.Context
{
	public class YurtDbContext : DbContext
	{
		public YurtDbContext(DbContextOptions<YurtDbContext> options) : base(options)
		{
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<ExchangeRate> ExchangeRates { get; set; }
		public DbSet<IncomeDetail> IncomeDetails { get; set; }
		public DbSet<PaymentDetail> PaymentDetails { get; set; }
		public DbSet<Record> Records { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomIncome> RoomIncomes { get; set; }
		public DbSet<AppUser> Users { get; set; }
		public DbSet<Image> Images { get; set; }


		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{

			foreach (var item in ChangeTracker.Entries())
			{
				if (item.Entity is BaseEntity entityReference)
				{
					switch (item.State)
					{
						case EntityState.Added:
							{
								entityReference.CreatedDate = DateTime.Now;
								break;
							}
						case EntityState.Modified:
							{
								Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;

								entityReference.UpdatedDate = DateTime.Now;
								break;
							}


					}
				}


			}









			return base.SaveChangesAsync(cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			base.OnModelCreating(modelBuilder);
		}



	}
}
