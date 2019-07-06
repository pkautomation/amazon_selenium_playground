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

        public static bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
