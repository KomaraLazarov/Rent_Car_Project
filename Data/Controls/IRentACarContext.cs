using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Controls
{
    public interface IRentACarContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Rental> Rentals { get; set; }
    }
}
