using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Data.Entity;
using Business;
using Data.Controls;
using Business.Controls;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RentACarProject.Tests
{
    public class SignUpTests
    {
        private const string fakeUsername = "KostadinBundov";
        private const string fakePassword = "kok123";
        private const string fakeFirstName = "Kostadin";
        private const string fakeSecondName = "Kostadinov";
        private const string fakeLastName = "Bundov";
        private const string fakeEmail = "koksibundov@gmail.com";
        private const string fakePhoneNumber = "0886008605";
        private DateTime fakeDateTime = new DateTime(12 / 25 / 2008);

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddUserIntoDatabaseAfterSignUp()
        {
            var data = new List<User>
            {

            }.AsQueryable();

            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<RentACarContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            var service = new RentACarBusiness(mockContext.Object);
            service.SignUp(new User(fakeUsername, fakePassword, fakeFirstName, fakeSecondName,
                fakeLastName, fakeEmail, fakePhoneNumber, fakeDateTime));

            mockSet.Verify(m => m.Add(It.IsAny<User>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}