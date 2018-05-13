using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace amazonTestsSelenium
{
    public class Utils
    {
        public static void GoToPage(IWebDriver driver, string url)
        {
            driver.Url = url;
            driver.Navigate();
        }
    }
}
