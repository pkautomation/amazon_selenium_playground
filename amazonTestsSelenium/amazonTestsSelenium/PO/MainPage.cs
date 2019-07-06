using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace amazonTestsSelenium.Tests
{
    public class MainPage :InitialSetup
    {
        public IWebElement SearchBox => driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement ProfileCard => driver.FindElementByCssSelector(".hud-profilecard-name");
        public IWebElement BasketButton => driver.FindElementByCssSelector(".nav-cart-icon.nav-sprite");
        public IWebElement LoginButton => driver.FindElementByCssSelector("#nav-link-yourAccount");
        public IWebElement ShopByDepartmentButton => driver.FindElementByCssSelector("#nav-shop .nav-line-1");
        public IWebElement AmazonMusicListElement => driver.FindElementByXPath("//span[@role='navigation']/span[contains(text(), 'Amazon Music')]");
        public IWebElement AmazonMusicUnlimitedLink => driver.FindElementByXPath("//div/a[1]/span[contains(text(), 'Amazon Music Unlimited')]");

        public ShoppingBasket ClickBasket()
        {
            BasketButton.Click();
            return new ShoppingBasket();
        }

        public LoginForm ClickLoginButton()
        {
            LoginButton.Click();
            return new LoginForm();
        }
        public AmazonMusicUnlimited GoToAmazonMusicUnlimited()
        {
            var action = new Actions(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
         
            wait.Until(abc => ShopByDepartmentButton);
            action.MoveToElement(ShopByDepartmentButton, 10, 10).Build().Perform();

            wait.Until(abc => AmazonMusicListElement);
            action.MoveToElement(AmazonMusicListElement, 10, 10).Build().Perform();

            wait.Until(abc => AmazonMusicUnlimitedLink);
            action.MoveToElement(AmazonMusicUnlimitedLink, 10, 10).Click().Build().Perform();

            return new AmazonMusicUnlimited();
        }
    }
}
