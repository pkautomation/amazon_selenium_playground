using OpenQA.Selenium;

namespace amazonTestsSelenium.Tests
{
    public class LoginForm : InitialSetup
    {
        public IWebElement EmailTextBox => driver.FindElementByName("email");
        public IWebElement PasswordTextBox => driver.FindElementByName("password");

        public MainPage LogIn (string email, string password)
        {
            EmailTextBox.SendKeys(email);
            PasswordTextBox.SendKeys(password);
            PasswordTextBox.Submit();
            return new MainPage();
        }
    }
}
