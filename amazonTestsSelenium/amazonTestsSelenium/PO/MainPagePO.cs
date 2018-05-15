using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace amazonTestsSelenium.Tests
{
    public class MainPagePO :InitialSetup
    {

        public IWebElement searchBox => driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement profileCard => driver.FindElementByCssSelector(".hud-profilecard-name");
        public IWebElement basketButton => driver.FindElementByCssSelector(".nav-cart-icon.nav-sprite");
        public IWebElement loginButton => driver.FindElementByCssSelector("#nav-link-yourAccount");
        public IWebElement shopByDepartmentButton => driver.FindElementById("nav-shop");
        public IWebElement amazonMusicListElement => driver.FindElementByCssSelector("[aria-label='Amazon Music']");
        public IWebElement amazonMusicUnlimitedLink => driver.FindElementByXPath("//*[contains(text(), 'Amazon Music Unlimited')]");

        public ShoppingBasketPO ClickBasket()
        {
            basketButton.Click();
            return new ShoppingBasketPO();
        }

        public LoginFormPO ClickLoginButton()
        {
            loginButton.Click();
            return new LoginFormPO();
        }
        public void GoToAmazonMusicUnlimited()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(abc => shopByDepartmentButton);
            
            var action = new Actions(driver);
            action.MoveToElement(element).Perform();

            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element2 = wait2.Until(abc => amazonMusicListElement);

            var action2 = new Actions(driver);
            action2.MoveToElement(element2).MoveByOffset(10,10).Build().Perform();

            var action3 = new Actions(driver);
            action3.MoveToElement(element2).Perform();

            amazonMusicUnlimitedLink.Click();
        }

    }
}
