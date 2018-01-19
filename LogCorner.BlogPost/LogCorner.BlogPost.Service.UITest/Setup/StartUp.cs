using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow;

namespace LogCorner.BlogPost.Service.UITest.Setup
{
    [Binding]
    public class StartUp
    {
        private static SeleniumWebDriverStartup _seleniumTest = new SeleniumWebDriverStartup(ConfigurationManager.AppSettings["webSiteName"]);

        public static IWebDriver WebDriver
        {
            get { return _seleniumTest.WebDriver; }
        }

        [BeforeTestRun]
        public static void Start()
        {
            _seleniumTest.Initialize();
        }

        [AfterTestRun]
        public static void Down()
        {
            _seleniumTest.Cleanup();
        }
    }
}