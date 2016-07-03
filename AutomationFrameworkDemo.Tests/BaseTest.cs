using NUnit.Framework;

namespace AutomationFrameworkDemo.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Initialise();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
