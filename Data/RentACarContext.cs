using Business.Controls;
using Data.Controls;
using Data.Models;
using System.Data.Entity;

namespace Data
{
    public class RentACarContext : DbContext, IRentACarContext
    {
        public RentACarContext()
            : base("name=RentACarContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
