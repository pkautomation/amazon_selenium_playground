using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    public class ShoppingBasketPO
    {
        private RemoteWebDriver _driver;

        public IWebElement searchBox => _driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement emptyBasketMessage => _driver.FindElementByCssSelector(".a-row.sc-cart-header");

        public ShoppingBasketPO(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        
    }
}
