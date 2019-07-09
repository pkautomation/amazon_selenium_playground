using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

/* In this test group I am moving context between steps using ScenarioContext */

namespace amazonTestsSelenium.Tests
{
    [Binding]
    public class MainPageTests : InitialSetup
    {
        private MainPage mainPage;
        private ShoppingBasket basket;
        private AmazonMusicUnlimited amazonUnlimitedPage;

        [Given(@"Main page is opened")]
        public void GivenMainPageIsOpened()
        {
            Utils.GoToPage("https://amazon.co.uk");
            mainPage = new MainPage();
        }

        [When(@"I enter the phrase ""(.*)""")]
        public void WhenIEnterThePhrase(string p0)
        {
            var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
            wait.Until(abc => mainPage.SearchBox);

            mainPage.SearchBox.Click();
            mainPage.SearchBox.SendKeys("abcdefghijklmnopqrstuvwxyz");
            mainPage.SearchBox.Submit();
        }

        [Then(@"I can see ""(.*)"" Notebook on the list")]
        public void ThenICanSeeNotebookOnTheList(string p0)
        {
            var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
            var sth = wait.Until(abc => abc.FindElement(By.PartialLinkText("ABCDEFGHIJKLMNOPQRSTUVWXYZ")));
            Assert.IsTrue(sth.Text.Contains(p0));
        }

        [When(@"I click basket button")]
        public void WhenIClickBasketButton()
        {
            Utils.GoToPage("https://amazon.co.uk");
            MainPage mainPage = new MainPage();
            basket = mainPage.ClickBasket();
        }

        [Then(@"I get an empty basket message")]
        public void ThenIGetAnEmptyBasketMessage()
        {
            Assert.IsTrue(basket.EmptyBasketMessage.Text.Contains("is empty."), "Wrong basket message:" + basket.EmptyBasketMessage.Text);
        }

        [When(@"I click link to Amazon Music Unlimited from the dropdown")]
        public void WhenIClickLinkToAmazonMusicUnlimitedFromTheDropdown()
        {
            amazonUnlimitedPage = mainPage.GoToAmazonMusicUnlimited();
        }

        [Then(@"I will be at the offer page")]
        public void ThenIWillBeAtTheOfferPage()
        {
            Assert.IsTrue(Utils.IsElementPresent(By.CssSelector("[alt='Digital Music']")));
        }
    }
}
