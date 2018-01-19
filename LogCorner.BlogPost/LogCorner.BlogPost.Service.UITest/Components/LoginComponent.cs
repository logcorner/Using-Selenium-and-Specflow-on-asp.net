using OpenQA.Selenium;
using System;

namespace LogCorner.BlogPost.Service.UITest.Components
{
    public class LoginComponent
    {
        private IWebDriver _webDriver;

        private string _userName;

        private string _password;

        private IWebElement _root
        {
            get
            {
                return _webDriver.FindElement(By.Id("loginForm"));
            }
        }

        public LoginComponent(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string IsAt()
        {
            if (_root != null)
            {
                return _webDriver.Url;
            }
            return string.Empty;
        }

        public LoginComponent LoginAs(string userName)
        {
            _userName = userName;
            return this;
        }

       

        internal LoginComponent WithPassword(string password)
        {
            _password = password;
            return this;
        }

        internal void Login()
        {
            var loginInput = _root.FindElement(By.Id("Email"));
            loginInput.SendKeys(_userName);

            var passwordInput = _root.FindElement(By.Id("Password"));
            passwordInput.SendKeys(_password);

            var loginButton = _root.FindElement(By.XPath("//*[@type='submit']"));
            loginButton.Click();
        }
    }
}