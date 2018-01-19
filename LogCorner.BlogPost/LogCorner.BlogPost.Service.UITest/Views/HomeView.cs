using System;
using LogCorner.BlogPost.Service.UITest.Setup;

namespace LogCorner.BlogPost.Service.UITest.Page
{
    public class HomeView : Browser
    {
        private static string PageTitle = "Immobilier de luxe | Immobilier de prestige";

        private MenuComponent _menuComponent;

        public HomeView()
        {
            _menuComponent = new MenuComponent(WebDriver);
        }

        public void Goto()
        {
            Goto(WebSiteUrl);
        }

        public bool IsAt()
        {
            return Title == PageTitle;
        }

        internal bool IsNotAuthenticatedUser(string email)
        {
            return _menuComponent.IsNotAuthenticatedUser(email);
        }

        //internal object IsAuthenticatedUser(string email)
        //{
        //    return _menuComponent.IsAuthenticatedUser(email);
        //}

        //internal bool IsAuthenticatedUser(string email, string password)
        //{
        //  return  _menuComponent.IsAuthenticatedUser(email,password);
        //}
    }
}