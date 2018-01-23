using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Setup
{
    public abstract class IISRexpressServerStartup
    {
        private int _iisPort
        {
            get
            {
                int value = 0;
                if (int.TryParse(ConfigurationManager.AppSettings["webSitePort"], out value))
                {
                    return value;
                }
                throw new InvalidOperationException("Port number incorrect");
            }
        }

        private readonly string _applicationName;
        private static Process _iisProcess;

        protected IISRexpressServerStartup(string applicationName)
        {
            _applicationName = applicationName;
        }

        public void TestInitialize()
        {
            // TODO : uncomment to start IISExpress
            StartIIS();
        }

        public void TestCleanup()
        {
            if (_iisProcess.HasExited == false)
            {
                // TODO : uncomment to stop IISExpress
                _iisProcess.Kill();
            }
        }

        public abstract void Initialize();

        public abstract void Cleanup();

        private void StartIIS()
        {
            var applicationPath = GetApplicationPath(_applicationName);
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            _iisProcess = new Process();
            _iisProcess.StartInfo.FileName = programFiles + @"\IIS Express\iisexpress.exe";
            _iisProcess.StartInfo.Arguments = string.Format("/path:\"{0}\" /port:{1}", applicationPath, _iisPort);
            _iisProcess.Start();
        }

        protected string GetApplicationPath(string applicationName)
        {
            var projectFolder = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));
            var parent =  Directory.GetParent(projectFolder);
            return Path.Combine(parent.FullName, applicationName);
        }

        public string GetAbsoluteUrl(string relativeUrl)
        {
            if (!relativeUrl.StartsWith("/"))
            {
                relativeUrl = "/" + relativeUrl;
            }
            return string.Format("http://localhost:{0}/{1}", _iisPort, relativeUrl);
        }
    }
}