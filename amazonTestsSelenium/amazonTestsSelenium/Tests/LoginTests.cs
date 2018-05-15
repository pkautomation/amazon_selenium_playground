using amazonTestsSelenium.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace amazonTestsSelenium.Tests
{
    [TestClass]
    public class LoginTests : InitialSetup
    {
        [TestMethod]
        public void CheckSigningIn()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            MainPagePO mainPage = new MainPagePO();
            var loginForm = mainPage.ClickLoginButton();

            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(@"../../../Helpers/user.json"));      
            var loggedMainPage = loginForm.LogIn(user.username, user.password);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(abc => loggedMainPage.profileCard);

            Assert.IsTrue(loggedMainPage.profileCard.Text.Contains("Pawel"), "invalid login");
        }
    }
}
