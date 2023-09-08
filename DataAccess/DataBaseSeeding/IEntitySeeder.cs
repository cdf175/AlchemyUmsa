using Microsoft.EntityFrameworkCore;

namespace AlchemyUmsa.DataAccess.DataBaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDataBase(ModelBuilder modelBuilder);
    }
}
