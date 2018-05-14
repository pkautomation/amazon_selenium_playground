using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace amazonTestsSelenium.Tests
{
    public class MainPagePO
    {
        private RemoteWebDriver _driver;

        public IWebElement searchBox => _driver.FindElementByCssSelector("#twotabsearchtextbox");
        public IWebElement profileCard => _driver.FindElementByCssSelector(".hud-profilecard-name");
        public IWebElement basketButton => _driver.FindElementByCssSelector(".nav-cart-icon.nav-sprite");
        public IWebElement loginButton => _driver.FindElementByCssSelector("#nav-link-yourAccount");
        public IWebElement shopByDepartmentButton => _driver.FindElementById("nav-shop");
        public IWebElement amazonMusicListElement => _driver.FindElementByCssSelector("[aria-label='Amazon Music']");
        public IWebElement amazonMusicUnlimitedLink => _driver.FindElementByXPath("//*[contains(text(), 'Amazon Music Unlimited')]");

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
        public AmazonMusicUnlimitedPO GoToAmazonMusicUnlimited()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(abc => shopByDepartmentButton);
            
            var action = new Actions(_driver);
            action.MoveToElement(element).Perform();

            var wait2 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var element2 = wait2.Until(abc => amazonMusicListElement);

            var action2 = new Actions(_driver);
            action2.MoveToElement(element2).MoveByOffset(10,10).Build().Perform();

            var action3 = new Actions(_driver);
            action3.MoveToElement(element2).Perform();

            amazonMusicUnlimitedLink.Click();

            return new AmazonMusicUnlimitedPO(_driver);
        }
    }
}
