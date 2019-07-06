using OpenQA.Selenium;

namespace amazonTestsSelenium.Tests
{
    public class AmazonMusicUnlimited : InitialSetup
    {
        public IWebElement AmazonMusicUnlimitedButton => driver.FindElementByXPath("//*[contains(text(), 'Start your 30-day free trial')]");
    }
}
