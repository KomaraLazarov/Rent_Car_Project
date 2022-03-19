using Business.Controls;
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

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
    }
}
