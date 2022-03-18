using Data.Controls;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        public void UserWithValidPasswordShouldLogIn()
        {
            Mock<IUser> fakeUser = new Mock<IUser>();
            fakeUser.Setup(u => u.Username).Returns(fakeUsername);
            fakeUser.Setup(u => u.Password).Returns(fakePassword);
            Assert.AreEqual("4oekaLe6*", fakeUser.Object.Password, "Password is invalid!");
        }
    }
}
