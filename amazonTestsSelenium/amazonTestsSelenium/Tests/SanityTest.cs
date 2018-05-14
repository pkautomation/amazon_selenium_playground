using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace amazonTestsSelenium.Tests
{
    [TestClass]
    public class SanityTest : InitialSetup
    {


        [TestMethod]
        public void CheckSanity()
        {
            Utils.GoToPage(driver, "https://amazon.co.uk");
            Assert.IsTrue(driver.Title.Contains("Amazon"), "Failed Sanity test");
        }
    }
}
