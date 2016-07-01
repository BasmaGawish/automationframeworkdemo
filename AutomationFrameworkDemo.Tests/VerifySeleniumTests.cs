using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameworkDemo.Tests
{
    [TestFixture]
    public class VerifySeleniumTests
    {
        [Test]
        public void VerifySelenium()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:52046/");
            driver.Dispose(); //required to close the web driver
        }
    }
}
