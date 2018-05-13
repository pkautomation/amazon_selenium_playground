using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    public class MainPagePO
    {
        private RemoteWebDriver _driver;

        public IWebElement SearchBox => _driver.FindElementByCssSelector("#twotabsearchtextbox");

        public MainPagePO(RemoteWebDriver driver)
        {
            _driver = driver;
        }
    }
}
