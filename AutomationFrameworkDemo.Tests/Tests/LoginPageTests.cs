using AutomationFrameworkDemo.Tests.Pages;
using NUnit.Framework;

namespace AutomationFrameworkDemo.Tests.Tests
{
    [TestFixture]
    public class LoginPageTests : BaseTest
    {
        [Test]
        public void Login_WithValidUserNameAndPassword_ThenUserRedirectedToHomePage()
        {
            LoginPage loginpage = new LoginPage();
            loginpage.OpenURL();
            var homePage = loginpage.Login("admin@notvaliddomain.com", "P@ssw0rd");
            Assert.IsTrue(homePage.IsHere());
        }
    }
}
