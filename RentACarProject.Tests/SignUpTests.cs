using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Business;

namespace RentACarProject.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddUserIntoDatabase()
        {
            //Mock mockSet = new Mock<DbSet<User>>();

            //Mock mockContext = new Mock<RentACarContext>();
            //mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            //var service = new RentACarBusiness(mockContext.Object);
            //service.LogIn("Kostadin", "12345"); ;

            //mockSet.Verify(m => m.Add(It.IsAny<Car>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}