using System;
using LogCorner.BlogPost.Web.Mvc.UITest.Setup;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Page
{
    public class BlogListView : Browser
    {
        private BlogListComponent _blogListComponent;

        public BlogListView()
        {
            _blogListComponent = new BlogListComponent(WebDriver);
        }

        public void ClickOnCreateBlogLink()
        {
            _blogListComponent.ClickOnCreateBlogLink();
        }

        internal bool IsAt()
        {
            return _blogListComponent.IsAt()  == $"{WebSiteUrl}/Blog"; 
        }

        internal void Goto()
        {
            Goto($"{WebSiteUrl}/Blog");
        }
    }
}