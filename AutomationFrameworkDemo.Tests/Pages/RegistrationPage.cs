

using OpenQA.Selenium;

namespace AutomationFrameworkDemo.Tests.Pages
{
    public class RegistrationPage
    {
        public void OpenURL()
        {
            Driver.DriverInstance.Navigate().GoToUrl(Driver.BaseAddress + "/Account/Register");
        }

        public RegistrationPage EnterEmail(string email)
        {
            var emailField = Driver.DriverInstance.FindElement(By.ClassName("ui-email"));
            emailField.SendKeys(email);
            return this;
        }
        public RegistrationPage EnterPassword(string password)
        {
            var passwordField = Driver.DriverInstance.FindElement(By.ClassName("ui-password"));
            passwordField.SendKeys(password);
            return this;
        }
        public RegistrationPage EnterConfirmPassword(string confirmPassword)
        {
            var confirmPasswordField = Driver.DriverInstance.FindElement(By.ClassName("ui-confirm-password"));
            confirmPasswordField.SendKeys(confirmPassword);
            return this;
        }
        public HomePage Submit()
        {
            var loginButton = Driver.DriverInstance.FindElement(By.ClassName("ui-register-button"));
            loginButton.Click();
            return new HomePage();
        }

        public HomePage Register(string email, string password, string confirmPassword)
        {
            EnterEmail(email);
            EnterPassword(password);
            EnterConfirmPassword(confirmPassword);
            return Submit();
        }
    }
}
