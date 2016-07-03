using OpenQA.Selenium;
using System;

namespace AutomationFrameworkDemo.Tests.Pages
{
    public class LoginPage
    {
        public void OpenURL()
        {
            Driver.DriverInstance.Navigate().GoToUrl(Driver.BaseAddress + "/Account/Login");
        }

        public LoginPage EnterEmail(string email)
        {
            var emailField = Driver.DriverInstance.FindElement(By.ClassName("ui-email"));
            emailField.SendKeys(email);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            var passwordTextField = Driver.DriverInstance.FindElement(By.ClassName("ui-password"));
            passwordTextField.SendKeys(password);
            return this;
        }

        public HomePage ClickLogin()
        {
            var loginButton = Driver.DriverInstance.FindElement(By.ClassName("ui-login-button"));
            loginButton.Click();
            return new HomePage();
        }

        public HomePage Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickLogin();
        }
    }
}
