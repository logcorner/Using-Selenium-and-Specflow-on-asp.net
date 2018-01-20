using OpenQA.Selenium;
using System;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Page
{
    public class BlogListComponent
    {
        private IWebDriver _webDriver;

        private IWebElement _root
        {
            get
            {
                return _webDriver.FindElement(By.Id("listBlogTable"));
            }
        }

        public BlogListComponent(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ClickOnCreateBlogLink()
        {
            _root.FindElement(By.Id("CreateNewBlogLink")).Click();
        }

        internal string IsAt()
        {
            if (_root != null)
            {
                return _webDriver.Url;
            }
            return string.Empty;
        }
    }
}