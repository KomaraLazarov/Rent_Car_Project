using Data.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Car : ICar
    {
        public Car()
        {
            this.Rentals = new Collection<Rental>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Mark { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Fuel { get; set; }
        [Required]
        public string Transmition { get; set; }
        [Required]
        public decimal PricePerDay { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
