using AlchemyUmsa.DataAccess;
using AlchemyUmsa.DataAccess.Repositories;
using AlchemyUmsa.DataAccess.Repositories.Interfaces;

namespace AlchemyUmsa.Services
{
    public class UnitOfWorkService:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UserRepository UserRepository { get; private set; }
        public UnitOfWorkService(ApplicationDbContext context) {
            _context = context; 
            UserRepository = new UserRepository(_context);
        }

        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
