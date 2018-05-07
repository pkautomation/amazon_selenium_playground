using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace amazonTestsSelenium
{
    [TestClass]
    public class SanityTest
    {
        IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new FirefoxDriver();
        }

        [TestMethod]
        public void CheckSanity()
        {
            driver.Url = "https://amazon.co.uk";
            driver.Navigate();
            Assert.IsTrue(driver.Title.Contains("Amazon"), "Failed Sanity test");
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
