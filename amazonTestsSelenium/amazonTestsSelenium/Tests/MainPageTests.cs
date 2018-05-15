﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
            MainPagePO mainPage = new MainPagePO();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(abc => mainPage.searchBox);

            mainPage.searchBox.Click();
            mainPage.searchBox.SendKeys("abcdefghijklmnopqrstuvwxyz");
            mainPage.searchBox.Submit();

            var sth = wait.Until(abc => abc.FindElement(By.CssSelector("h2[data-attribute='ABCDEFGHIJKLMNOPQRSTUVWXYZ Notebook']")));

            Assert.IsTrue(sth.Text.Contains("ABCDEFGH"));
        }

        [TestMethod]
        public void CheckIfEmptyBasketGotMessage()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            MainPagePO mainPage = new MainPagePO();
            var basket = mainPage.ClickBasket();
            Assert.IsTrue(basket.emptyBasketMessage.Text.Contains("is empty."), "Wrong basket message:" + basket.emptyBasketMessage.Text);
        }

        [TestMethod]
        public void CheckMenu()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            MainPagePO mainPage = new MainPagePO();
            mainPage.GoToAmazonMusicUnlimited();
        }
    }
}
