using AutomationFrameworkDemo.Tests.Pages;
using NUnit.Framework;

namespace AutomationFrameworkDemo.Tests.Tests
{
    [TestFixture]
    public class RegistrationPageTests : BaseTest
    {
        [Test]
        public void Registration_WithValidUserNameAndPassword_RedirectsToHomePage()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.OpenURL();
            var homePage = registrationPage.Register(Faker.Internet.Email(), "P@ssw0rd", "P@ssw0rd");
            Assert.IsTrue(homePage.IsHere());
        }
    }
}
