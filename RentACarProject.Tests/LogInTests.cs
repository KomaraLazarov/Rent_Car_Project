using Business;
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
    class LogInTests
    {
        private const string fakeUsername = "KomaraLazarov";
        private const string fakePassword = "4oekaLe6*";

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void UserWithValidPasswordAndUsernameIsLoggedInTheSystem()
        {
            var service = new Mock<RentACarBusiness>();
            service.Setup(m => m.LogIn(fakeUsername, fakePassword)).Returns(true);

            bool isLogged = service.Object.LogIn(fakeUsername, fakePassword);

            Assert.AreEqual(true, isLogged, "User is not logged in the system!");
        }

    }
}
