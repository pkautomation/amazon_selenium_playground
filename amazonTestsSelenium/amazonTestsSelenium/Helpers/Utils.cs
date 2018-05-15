using OpenQA.Selenium;

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
