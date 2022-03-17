using System;
using Data.Controls;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Rental : IRental
    {
        /// <summary>
        /// Generate properties
        /// </summary>
        public Rental(int userId, int carId, DateTime hireDate, DateTime returnDate, decimal price)
        {
            this.UserId = userId;
            this.CarId = carId;
            this.HireDate = hireDate;
            this.ReturnDate = returnDate;
            this.TotalPrice = price;
        }
        public Rental() { }
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Column("TotalPrice", Order = 6)]
        public decimal TotalPrice { get; set; }
    }
}
