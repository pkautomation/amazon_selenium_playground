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
            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(@"../../../Helpers/user.json"));
            ScenarioContext.Current.Add("existingUser", user);
        }
        
        [When(@"Go to login page and fill the login form using existing user")]
        public void WhenGoToLoginPageAndFillTheLoginFormUsingExistingUser()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            MainPage page = new MainPage();
            LoginForm form = page.ClickLoginButton();
            User user = ScenarioContext.Current["existingUser"] as User;
            MainPage loggedMainPage = form.LogIn(user.username, user.password);

            ScenarioContext.Current.Add("loggedMainPage", loggedMainPage);
        }

        [Then(@"The user is logged in")]
        public void ThenTheUserIsLoggedIn()
        {
            var page = ScenarioContext.Current["loggedMainPage"] as MainPage;

            var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
            wait.Until(abc => page.profileCard);

            Assert.IsTrue(page.profileCard.Text.Contains("Pawel"), "invalid login");
        }

    }
}
