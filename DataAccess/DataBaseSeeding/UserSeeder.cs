using AlchemyUmsa.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlchemyUmsa.DataAccess.DataBaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Carlos", LastName = "Franco", Email = "cdf.175@gmail.com", Password = "123456" }
            );
        }
    }
}
