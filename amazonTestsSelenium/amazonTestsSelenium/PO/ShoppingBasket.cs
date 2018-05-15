using OpenQA.Selenium;
namespace amazonTestsSelenium.Tests
{
    public class ShoppingBasket : InitialSetup
    {
        public IWebElement searchBox => driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement emptyBasketMessage => driver.FindElementByCssSelector(".a-row.sc-cart-header");
    }
}
