using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Setup
{
    public class SeleniumWebDriverStartup : IISRexpressServerStartup
    {
        //private RemoteWebDriver _remoteWebDriver;
        private IWebDriver _remoteWebDriver;

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
          ////////  options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
          ////////  _remoteWebDriver = new InternetExplorerDriver(options);*/

            ////////  ChromeOptions options = new ChromeOptions();

            ////////  options.AddArgument(@"C:\TEAMPROJECT\GIT\selenim specflow\blog\LogCorner.BlogPost\LogCorner.BlogPost.Service.UITest\bin\Debug\chromedriver.exe");
            ////////  //options.AddArgument("--headless");
            ////////  _remoteWebDriver = new ChromeDriver(options);

            //////////  _remoteWebDriver = new ChromeDriver(@"C:\TEAMPROJECT\GIT\selenim specflow\blog\LogCorner.BlogPost\LogCorner.BlogPost.Service.UITest\bin\Debug");
            //Create a chrome options object

            ////////////////////////var chromeOptions = new ChromeOptions();
            //////////////////////////Create a new proxy object
            ////////////////////////var proxy = new Proxy();
            //////////////////////////Set the http proxy value, host and port.
            ////////////////////////proxy.HttpProxy = "http://localhost:62300";
            //////////////////////////Set the proxy to the Chrome options
            ////////////////////////chromeOptions.Proxy = proxy;
            //////////////////////////Then create a new ChromeDriver passing in the options
            //////////////////////////ChromeDriver path isn't required if its on your path
            //////////////////////////If it now downloaded it and put the path here
            ////////////////////////_remoteWebDriver = new ChromeDriver(chromeOptions);

            ////////////////////////ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\TEAMPROJECT\GIT\selenim specflow\blog\LogCorner.BlogPost\LogCorner.BlogPost.Service.UITest\bin\Debug");
            ////////////////////////service.Port = 80;

            _remoteWebDriver = new ChromeDriver();
            _remoteWebDriver.Manage().Window.Maximize();
        }

        private IWebDriver IEDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            _remoteWebDriver = new InternetExplorerDriver(options);
            return _remoteWebDriver;
        }

        public override void Cleanup()
        {
            _remoteWebDriver.Dispose();
            TestCleanup();
        }
    }
}