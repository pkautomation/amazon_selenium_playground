using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    public class ShoppingBasketPO : InitialSetup
    {
        public IWebElement searchBox => driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement emptyBasketMessage => driver.FindElementByCssSelector(".a-row.sc-cart-header");
    }
}
