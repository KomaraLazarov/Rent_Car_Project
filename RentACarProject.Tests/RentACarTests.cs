using Business;
using Business.Controls;
using Data;
using Data.Controls;
using Data.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Tests
{
    class RentACarTests
    {
        private const string fakeUsername = "KostadinBundov";
        private static string fakeCarProp = "Audi A7 2020";
        private string[] fakeProperties = fakeCarProp.Split();
        private DateTime fakeHireDate = new DateTime(11 / 25 / 2008);
        private DateTime fakeReturnDate = new DateTime(11 / 30 / 2008);
        private const int fakeUserId = 1;
        private const int fakeCarId = 1;
        private const decimal fakePrice = 2500.00M;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddCarIntoDatabaseAfterRenting()
        {
            var data = new List<Rental>
            {

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Rental>>();
            mockSet.As<IQueryable<Rental>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Rental>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Rental>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Rental>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<RentACarContext> mockContext = new Mock<RentACarContext>();
            mockContext.Setup(m => m.Rentals).Returns(mockSet.Object);

            Rental rental = new Rental(fakeUserId, fakeCarId, fakeHireDate, fakeReturnDate, fakePrice);

            mockSet.Object.Add(rental);

            mockSet.Verify(m => m.Add(It.IsAny<Rental>()), Times.Once());
        }
        
        [Test]
        public void GetCarIdCorrectly()
        {       
            var service = new Mock<RentACarBusiness>();
            service.Setup(m => m.GetCarId(fakeProperties)).Returns(fakeCarId);

            int carId = service.Object.GetCarId(fakeProperties);

            Assert.AreEqual(fakeCarId, carId, "Not taken properly CarId!");
        }

        [Test]
        public void CalculateTotalPriceAfterClickTheButton()
        {
            var service = new Mock<RentACarBusiness>();
            service.Setup(m => m.CalculateTotalPrice(fakeHireDate, fakeReturnDate, fakeProperties)).Returns(fakePrice);

            decimal price = service.Object.CalculateTotalPrice(fakeHireDate, fakeReturnDate, fakeProperties);

            Assert.AreEqual(fakePrice, price, "Not calculate properly the total price!");
        }
    }
}
