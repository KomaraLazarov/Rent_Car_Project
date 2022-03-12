using Data.Models;
using System.Data.Entity;

namespace Data
{
    public class RentACarContext : DbContext
    {
        public RentACarContext()
            : base("name=RentACarContext")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Rental> Rental { get; set; }
    }
}
