using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace amazonTestsSelenium.Tests
{
    [TestClass]
    public class SanityTest : InitialSetup
    {
        [TestMethod]
        public void CheckSanity()
        {
            Utils.GoToPage("https://amazon.co.uk");
            Assert.IsTrue(driver.Title.Contains("Amazon"), "Failed Sanity test");
        }
    }
}
