using OpenQA.Selenium;

namespace amazonTestsSelenium.Tests
{
    public class LoginForm : InitialSetup
    {
        public IWebElement emailTextBox => driver.FindElementByName("email");
        public IWebElement passwordTextBox => driver.FindElementByName("password");

        public MainPage LogIn (string email, string password)
        {
            emailTextBox.SendKeys(email);
            passwordTextBox.SendKeys(password);
            passwordTextBox.Submit();
            return new MainPage();
        }
    }
}
