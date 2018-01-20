using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Setup
{
    public class SeleniumWebDriverStartup : IISRexpressServerStartup
    {
        private RemoteWebDriver _remoteWebDriver;

        public IWebDriver WebDriver
        {
            get { return _remoteWebDriver; }
        }

        public SeleniumWebDriverStartup(string applicationName) : base(applicationName)
        {
        }

        public override void Initialize()
        {
            TestInitialize();
            /*var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            _remoteWebDriver = new InternetExplorerDriver(options);*/
            _remoteWebDriver = new ChromeDriver();
            _remoteWebDriver.Manage().Window.Maximize();
        }

        public override void Cleanup()
        {
            _remoteWebDriver.Dispose();
            TestCleanup();
        }
    }
}