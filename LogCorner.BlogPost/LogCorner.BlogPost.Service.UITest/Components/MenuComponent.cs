using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace LogCorner.BlogPost.Service.UITest.Page
{
    internal class MenuComponent
    {
        private IWebDriver webDriver;

        private IWebElement _rootMenu
        {
            get
            {
                return webDriver.FindElement(By.XPath("//div[@class='navbar navbar-inverse navbar-fixed-top']"));
            }
        }

        public MenuComponent(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        internal bool IsNotAuthenticatedUser(string email)
        {
            var registerLink = _rootMenu.FindElement(By.Id("registerLink"));
            var loginLink = _rootMenu.FindElement(By.Id("loginLink"));

            return loginLink != null && registerLink != null && loginLink.Text == "Log in" && registerLink.Text == "Register";
        }

        internal void ClickOnLoginLink()
        {
            ClickOnLogOffLink();
             var loginLink = _rootMenu.FindElement(By.Id("loginLink"));
            loginLink.Click();
        }

        internal void ClickOnLogOffLink()
        {
            var loginLink = _rootMenu.FindElement(By.LinkText("Log off"));
            loginLink.Click();
        }

        internal bool IsAuthenticatedUser(string email)
        {
            return true;
        }
    }
}