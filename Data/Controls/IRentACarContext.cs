using Data.Models;
using System.Data.Entity;

namespace Data.Controls
{
    public interface IRentACarContext
    {
        DbSet<User> User { get; set; }
        DbSet<Car> Car { get; set; }
        DbSet<Rental> Rental { get; set; }
    }
}
