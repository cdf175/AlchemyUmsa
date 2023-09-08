using AlchemyUmsa.DataAccess.Repositories;

namespace AlchemyUmsa.Services
{
    public interface IUnitOfWork:IDisposable
    {
        public UserRepository UserRepository { get; }
        Task<int> Complete();

    }
}
