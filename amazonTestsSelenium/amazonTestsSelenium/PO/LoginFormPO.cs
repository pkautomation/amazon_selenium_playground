
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace amazonTestsSelenium.Tests
{
    public class LoginFormPO : InitialSetup
    {
        public IWebElement emailTextBox => driver.FindElementByName("email");
        public IWebElement passwordTextBox => driver.FindElementByName("password");

        public MainPagePO LogIn (string email, string password)
        {
            emailTextBox.SendKeys(email);
            passwordTextBox.SendKeys(password);
            passwordTextBox.Submit();
            return new MainPagePO();
        }
    }
}
