using Project.Core.UnitOfWorks;
using Project.Repository.Context;

namespace Project.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly YurtDbContext _context;

        public UnitOfWork(YurtDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
