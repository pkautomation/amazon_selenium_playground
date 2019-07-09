using OpenQA.Selenium;

namespace amazonTestsSelenium
{
    public class Utils : InitialSetup
    {
        public static void GoToPage(string url)
        {
            driver.Url = url;
            driver.Navigate();
        }

        public static bool IsElementPresent(By by)
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
