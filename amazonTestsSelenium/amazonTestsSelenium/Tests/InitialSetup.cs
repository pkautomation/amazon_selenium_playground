using amazonTestsSelenium;
using amazonTestsSelenium.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.IO;

// Preparation of basic data

[TestClass]
public abstract class InitialSetup
{
    public static RemoteWebDriver driver;
    public static User user;

    [AssemblyInitialize]
    public static void SetUp(TestContext context)
    {
        driver = new FirefoxDriver("./");
        Utils.GoToPage("https://amazon.co.uk");
        user = JsonConvert.DeserializeObject<User>(File.ReadAllText(@"../../../Helpers/user.json"));
    }

    [AssemblyCleanup]
    public static void CleanUp()
    {
        driver.Quit();
    }
}
