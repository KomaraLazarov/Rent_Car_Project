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

        public DbSet<User> Users { get; set; }
    }
}
