﻿using System;

namespace Data.Models
{
    public class User
    {
        public User(string username, string password, string firstName, string middleName, string lastName, string email, string phoneNumber, DateTime birthDate)
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
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
