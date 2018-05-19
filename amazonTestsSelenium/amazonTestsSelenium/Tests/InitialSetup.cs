using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

[TestClass]
public abstract class InitialSetup
{
    public static RemoteWebDriver driver;

    [AssemblyInitialize]
    public static void SetUp(TestContext context)
    {
        driver = new FirefoxDriver("../../../../");
    }

    [AssemblyCleanup]
    public static void CleanUp()
    {
        driver.Quit();
    }
}
