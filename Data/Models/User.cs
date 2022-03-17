using Data.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class User : IUser
    {
        /// <summary>
        /// Generate properties
        /// </summary>
        public User(string username, string password, string firstName, string middleName, string lastName, string email, string phoneNumber, DateTime birthDate)
            :this()
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Birthdate = birthDate;
        }
        public User()
        {
            this.Rentals = new Collection<Rental>();
        }

        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
