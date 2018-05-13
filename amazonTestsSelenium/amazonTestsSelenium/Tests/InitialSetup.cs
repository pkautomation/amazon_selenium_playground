using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

public class InitialSetup
    {
        public RemoteWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new FirefoxDriver("./");
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
