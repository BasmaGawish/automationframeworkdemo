using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameworkDemo.Tests
{
    public class Driver
    {
        public static IWebDriver DriverInstance { get; set; }

        public static string BaseAddress
        {
            get { return "http://localhost:52046/"; }
        }

        public static void Initialise()
        {
            DriverInstance = new ChromeDriver();
        }
        public static void Close()
        {
            DriverInstance.Dispose();
        }
    }
}
