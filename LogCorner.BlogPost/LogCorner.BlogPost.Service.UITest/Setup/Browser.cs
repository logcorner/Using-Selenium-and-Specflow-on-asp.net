using OpenQA.Selenium;
using System;
using System.Configuration;

namespace LogCorner.BlogPost.Service.UITest.Setup
{
    public class Browser
    {
        protected string WebSiteUrl => $"{ConfigurationManager.AppSettings["webSiteHost"]}:{ConfigurationManager.AppSettings["webSitePort"]}";

        public string Title
        {
            get { return WebDriver.Title; }
        }

        protected IWebDriver WebDriver
        {
            get { return StartUp.WebDriver; }
        }

        public void Goto(string url)
        {
            WebDriver.Url = url;
        }

        protected void TurnOnWait()
        {
            WebDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
        }

        protected void TurnOffWait()
        {
            WebDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(0));
        }
    }
}