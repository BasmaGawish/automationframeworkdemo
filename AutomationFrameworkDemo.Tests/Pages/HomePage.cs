namespace AutomationFrameworkDemo.Tests.Pages
{
    public class HomePage
    {
        public bool IsHere()
        {
            return Driver.driver.Title == "Home Page - My ASP.NET Application";
        }
    }
}
