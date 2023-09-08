using AlchemyUmsa.DataAccess.Repositories.Interfaces;
using AlchemyUmsa.Entities;

namespace AlchemyUmsa.DataAccess.Repositories
{
    public class UserRepository:Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }


    }
}
