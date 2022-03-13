using Data;
using System;
using System.Linq;
using Data.Models;

namespace Business
{
    public class RentACarBusiness
    {
        private RentACarContext rentACarContext;

        public RentACarBusiness()
        {
            this.rentACarContext = new RentACarContext();
        }

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
        public decimal CalculateTotalPrice(DateTime hireDate, DateTime returnDate, string[] carProperties)
        {

            int totalDays = (returnDate - hireDate).Days;

            int carId = this.GetCarId(carProperties);

            decimal carPricePerDay = this.rentACarContext.Car.First(x => x.Id == carId).PricePerDay;

            decimal totalPrice = totalDays * carPricePerDay;

            return totalPrice;
        }
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
