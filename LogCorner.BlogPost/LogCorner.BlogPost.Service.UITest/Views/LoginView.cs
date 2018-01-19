using LogCorner.BlogPost.Service.UITest.Components;
using LogCorner.BlogPost.Service.UITest.Setup;

namespace LogCorner.BlogPost.Service.UITest.Page
{
    public class LoginView : Browser
    {
        private LoginComponent _loginComponent;
        private MenuComponent _menuComponent;

        public LoginView()
        {
            _loginComponent = new LoginComponent(WebDriver);
            _menuComponent = new Page.MenuComponent(WebDriver);
        }

        public bool IsAt()
        {
            return _loginComponent.IsAt() == $"{WebSiteUrl}/Account/Login?ReturnUrl=%2FBlog%2FCreate";
        }

        internal void Login(string email, string password)
        {
            _loginComponent.LoginAs(email).WithPassword(password).Login();
        }

        internal bool AuthenticatedUser(string email, string password)
        {
            _menuComponent.ClickOnLoginLink();
            _loginComponent.LoginAs(email).WithPassword(password).Login();
            return ! _menuComponent.IsAuthenticatedUser(email);
        }
    }
}