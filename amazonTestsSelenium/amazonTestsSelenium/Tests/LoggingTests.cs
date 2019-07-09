using amazonTestsSelenium.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

/* In this test group I am moving context between steps using ScenarioContext */

namespace amazonTestsSelenium.Tests
{
    [Binding]
    public class AbcSteps : InitialSetup
    {
        [Given(@"existing user name")]
        public void GivenExistingUserName()
        {
        }
        
        [When(@"Go to login page and fill the login form using existing user")]
        public void WhenGoToLoginPageAndFillTheLoginFormUsingExistingUser()
        {
            Utils.GoToPage("https://amazon.co.uk");
            MainPage page = new MainPage();
            LoginForm form = page.ClickLoginButton();
            MainPage loggedMainPage = form.LogIn(user.Username, user.Password);

            ScenarioContext.Current.Add("loggedMainPage", loggedMainPage);
        }

        [Then(@"The user is logged in")]
        public void ThenTheUserIsLoggedIn()
        {
            var page = ScenarioContext.Current["loggedMainPage"] as MainPage;

            var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
            wait.Until(abc => page.ProfileCard);

            Assert.IsTrue(page.ProfileCard.Text.Contains("Deliver to"), "invalid login");
        }

    }
}
