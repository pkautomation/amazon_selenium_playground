using OpenQA.Selenium;

namespace amazonTestsSelenium.Tests
{
    public class AmazonMusicUnlimited : InitialSetup
    {
        public IWebElement amazonMusicUnlimitedButton => driver.FindElementByXPath("//*[contains(text(), 'Start your 30-day free trial')]");
    }
}
