using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace amazonTestsSelenium.Tests
{
    public class AmazonMusicUnlimitedPO
    {
        private RemoteWebDriver _driver;
        public IWebElement amazonMusicUnlimitedButton => _driver.FindElementByXPath("//*[contains(text(), 'Start your 30-day free trial')]");

        public AmazonMusicUnlimitedPO(RemoteWebDriver driver)
        {
            _driver = driver;
        }
    }
}
