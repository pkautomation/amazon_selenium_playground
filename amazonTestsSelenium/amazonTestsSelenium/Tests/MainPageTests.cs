using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace amazonTestsSelenium.Tests
{
    [TestClass]
    public class MainPageTests : InitialSetup
    {
        [TestMethod]
        public void CheckSearchBar()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            MainPagePO mainPage = new MainPagePO(driver);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(abc => mainPage.SearchBox);
            mainPage.SearchBox.Click();
            mainPage.SearchBox.SendKeys("abcdefghijklmnopqrstuvwxyz");
            mainPage.SearchBox.Submit();
            var sth = wait.Until(abc => abc.FindElement(By.CssSelector("h2[data-attribute='ABCDEFGHIJKLMNOPQRSTUVWXYZ Notebook']")));
            Assert.IsTrue(sth.Text.Contains("ABCDEFGH"));
        }
    }
}
