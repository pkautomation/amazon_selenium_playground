using OpenQA.Selenium;
namespace amazonTestsSelenium.Tests
{
    public class ShoppingBasket : InitialSetup
    {
        public IWebElement SearchBox => driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement EmptyBasketMessage => driver.FindElementByCssSelector(".a-row.sc-cart-header");
    }
}
