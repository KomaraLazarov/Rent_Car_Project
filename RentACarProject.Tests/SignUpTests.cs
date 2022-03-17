using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Data.Entity;
using Business;
using Data.Controls;
using Business.Controls;
using System;

namespace RentACarProject.Tests
{
    public class Tests
    {
        private const string fakeUsername = "KostadinBundov";
        private const string fakePassword = "kok123";
        private const string fakeFirstName = "Kostadin";
        private const string fakeSecondName = "Kostadinov";
        private const string fakeLastName = "Bundov";
        private const string fakeEmail = "koksibundov@gmail.com";
        private const string fakePhoneNumber = "0886008605";
        private DateTime fakeDateTime = new DateTime(12 / 25 / 2008);

        private Mock<RentACarContext> fakeContext;

        [SetUp]
        public void Setup()
        {
            this.fakeContext = new Mock<RentACarContext>();
        }

        [Test]
        public void AddUserIntoDatabase()
        {
            var mockSetCar = new Mock<DbSet<User>>();

            var mockContext = new Mock<RentACarContext>();

            mockContext.Setup(m => m.Users).Returns(mockSetCar.Object);

            var fakeBusiness = new RentACarBusiness(mockContext.Object);

            fakeBusiness.SignUp(new User(fakeUsername, fakePassword, fakeFirstName, fakeSecondName, 
                fakeLastName, fakeEmail, fakePhoneNumber, fakeDateTime));

            mockSetCar.Verify(m => m.Add(It.IsAny<User>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}