using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameworkDemo.Tests
{
    public class Driver
    {
        public static IWebDriver driver = new ChromeDriver();

        public static string BaseAddress
        {
            get { return "http://localhost:52046/"; }
        }
    }
}
