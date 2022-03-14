using Business.Controls;
using Data.Controls;
using Moq;
using NUnit.Framework;

namespace RentACarProjectTests
{
    public class LogInTests
    {
        private const string fakeUsername = "Ivan";
        private const string fakePassword = "1234567890";

        private Mock<IRentACarContext> fakeContext;
        private Mock<IRentACarBusiness> fakeBusiness;

        [SetUp]
        public void Setup()
        {
            this.fakeContext = new Mock<IRentACarContext>();
            this.fakeBusiness = new Mock<IRentACarBusiness>();
        }

        [Test]
        public void UserWithValidPasswordShouldLogIn()
        {
            Mock<IUser> fakeUser = new Mock<IUser>();
            fakeUser.Setup(u => u.Username).Returns(fakeUsername);
            fakeUser.Setup(u => u.Password).Returns(fakePassword);

        }
        [Test]
        public void ValidUsernameWithIncorrectPasswordShouldNotLogIn()
        {

        }
        [Test]
        public void UnregisteredUserShouldNotLogIn()
        {

        }
    }
}