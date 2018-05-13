using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    public class MainPagePO
    {
        private RemoteWebDriver _driver;

        public IWebElement searchBox => _driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement profileCard => _driver.FindElementByCssSelector(".hud-profilecard-name");
        public IWebElement basketButton => _driver.FindElementByCssSelector(".nav-cart-icon.nav-sprite");
        public IWebElement loginButton => _driver.FindElementByCssSelector("#nav-link-yourAccount");

        public MainPagePO(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public ShoppingBasketPO ClickBasket()
        {
            basketButton.Click();
            return new ShoppingBasketPO(_driver);
        }

        public LoginFormPO ClickLoginButton()
        {
            loginButton.Click();
            return new LoginFormPO(_driver);
        }
    }
}
