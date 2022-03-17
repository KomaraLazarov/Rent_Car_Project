using Data;
using System;
using System.Linq;
using Data.Models;
using Business.Controls;

namespace Business
{
    public class RentACarBusiness : IRentACarBusiness
    {
        private RentACarContext rentACarContext;

        /// <summary>
        /// Initialize a new Context to use it in the program for all the methods.
        /// </summary>
        public RentACarBusiness()
        {
            this.rentACarContext = new RentACarContext();
        }

        /// <summary>
        /// Check if user with username is in database and if so, log user and
        /// allow rent a car. Otherwise, user cannot use any functionality.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Return true if user successfully logedIn,
        /// otherwise return false if password is incorrect or user doesn't
        /// exist in the system.
        /// </returns>
        public bool LogIn(string username, string password)
        {

            if (this.rentACarContext.User.Any(x => x.Username == username))
            {
                User currUser = this.rentACarContext.User.First(x => x.Username == username);

                if (currUser.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// SignUp new user in database if username doesn't exist in the database
        /// Contains info for user and add it into the system.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>
        /// return true if user successfuly signUp, otherwise return false because user already exist.
        /// </returns>
        public bool SignUp(User user)
        {

            if (this.rentACarContext.User.Any(x => x.Username == user.Username))
            {
                return false;
            }
            else
            {
                this.rentACarContext.User.Add(user);
                this.rentACarContext.SaveChanges();

                return true;
            }
        }
        /// <summary>
        /// Every car has price per day. Calculate total price of a car for a period of time without
        /// renting it.
        /// </summary>
        /// <param name="hireDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="carProperties"></param>
        /// <returns>
        /// returns total price for the selected period.
        /// </returns>
        public decimal CalculateTotalPrice(DateTime hireDate, DateTime returnDate, string[] carProperties)
        {

            int totalDays = (returnDate - hireDate).Days;

            int carId = this.GetCarId(carProperties);

            decimal carPricePerDay = this.rentACarContext.Car.First(x => x.Id == carId).PricePerDay;

            decimal totalPrice = totalDays * carPricePerDay;

            return totalPrice;
        }
        /// <summary>
        /// Check if user doesn't already hire a car for these period or if car
        /// isn't already hired. If so return appropriate message.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="carProperties"></param>
        /// <param name="hireDate"></param>
        /// <param name="returnDate"></param>
        public void MakeReservation(string username, string[] carProperties, DateTime hireDate, DateTime returnDate)
        {
            int carId = this.GetCarId(carProperties);
            int userId = this.rentACarContext.User.First(x => x.Username.CompareTo(username) == 0).Id;

            if (this.rentACarContext.Rental.Any(x => x.UserId == userId &&
                    ((x.HireDate <= hireDate && hireDate <= x.ReturnDate) ||
                    (x.HireDate <= returnDate && returnDate <= x.ReturnDate))))
            {
                throw new ArgumentException("User already hire car in this period!");
            }

            if (this.rentACarContext.Rental.Any(x => x.CarId == carId && 
                    ((x.HireDate <= hireDate && hireDate <= x.ReturnDate) ||
                    (x.HireDate <= returnDate && returnDate <= x.ReturnDate))))
            {
                throw new ArgumentException("Car already hire for this period!");
            }

            decimal price = this.CalculateTotalPrice(hireDate, returnDate, carProperties);
            Rental rental = new Rental(userId, carId, hireDate, returnDate, 125.00m);

            this.rentACarContext.Rental.Add(rental);
            this.rentACarContext.SaveChanges();
        }
        /// <summary>
        /// take car information properties and find it's id in the database system.
        /// </summary>
        /// <param name="carProperties"></param>
        /// <returns>id of the user.</returns>
        private int GetCarId(string[] carProperties)
        {
            string mark = carProperties[0];
            string model = carProperties[1];
            int year = int.Parse(carProperties[2]);

            int carId = this.rentACarContext.Car.First(x => x.Mark.CompareTo(mark) == 0 &&
                        x.Model.CompareTo(model) == 0 &&
                        x.Year.CompareTo(year) == 0).Id;

            return carId;
        }
    }
}
