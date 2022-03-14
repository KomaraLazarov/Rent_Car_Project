using Data.Models;
using System;

namespace Business.Controls
{
    public interface IRentACarBusiness
    {
        bool LogIn(string username, string password);
        bool SignUp(User user);
        decimal CalculateTotalPrice(DateTime hireDate, DateTime returnDate, string[] carProperties);
        void MakeReservation(string username, string[] carProperties, DateTime hireDate, DateTime returnDate);
    }
}
