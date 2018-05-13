
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    public class LoginFormPO
    {
        private RemoteWebDriver _driver;

        public IWebElement emailTextBox => _driver.FindElementByName("email");
        public IWebElement passwordTextBox => _driver.FindElementByName("password");

        public LoginFormPO(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public MainPagePO LogIn (string email, string password)
        {
            emailTextBox.SendKeys(email);
            passwordTextBox.SendKeys(password);
            passwordTextBox.Submit();
            return new MainPagePO(_driver);
        }
    }
}
