using System;
using LogCorner.BlogPost.Web.Mvc.UITest.Setup;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Page
{
    public class BlogCreateView : Browser
    {
        private BlogCreateComponent _blogCreateComponent;

        public BlogCreateView()
        {
            _blogCreateComponent = new BlogCreateComponent(WebDriver);
        }

        public bool IsAt()
        {
            return _blogCreateComponent.IsAt() == $"{WebSiteUrl}/Blog/Create";
        }

        internal void Create(string url, string description)
        {
            _blogCreateComponent.WithUrl(url).WithDescription(description).Create();
        }
    }
}