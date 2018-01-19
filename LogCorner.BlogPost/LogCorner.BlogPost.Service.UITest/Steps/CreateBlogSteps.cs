using LogCorner.BlogPost.Service.UITest.Page;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace LogCorner.BlogPost.Service.UITest.Steps
{
    [Binding]
    public class CreateBlogSteps
    {
        private BlogListView _blogListView;
        private LoginView _loginView;
        private BlogCreateView _blogCreateView;
        private HomeView _homeView;

        public CreateBlogSteps(BlogListView blogListView, LoginView loginView, BlogCreateView blogCreateView, HomeView homeView)
        {
            _blogCreateView = blogCreateView;
            _blogListView = blogListView;
            _loginView = loginView;
            _homeView = homeView;
        }

        [Given(@"I m an anonymous user")]
        public void GivenIMAnAnonymousUser()
        {
            _homeView.Goto();
            var result = _homeView.IsNotAuthenticatedUser("");
        }

        [Given(@"I m an authenicated user (.*) (.*)")]
        public void GivenIMAnAuthenicatedUser(string email, string password)
        {
            _homeView.Goto();
            var result = _loginView.AuthenticatedUser(email,password);
        }

        [When(@"I naviagte to blog list page")]
        public void WhenINaviagteToBlogListPage()
        {
            _blogListView.Goto();
        }

        [When(@"I click on Create New Blog link")]
        public void WhenIClickOnCreateNewBlogLink()
        {
            _blogListView.ClickOnCreateBlogLink();
        }

        [Then(@"I must be redirected on login page")]
        public void ThenIMustBeRedirectedOnLoginPage()
        {
            var result = _loginView.IsAt();
            Assert.True(result, "The login view must be displayed");
        }

        [When(@"I logged in (.*) (.*)")]
        public void WhenILoggedIn(string email, string password)
        {
            _loginView.Login(email, password);
        }

        [Then(@"I must be redirected on CreateBlogPage")]
        public void ThenIMustBeRedirectedOnCreateBlogPage()
        {
            var result = _blogCreateView.IsAt();
        }

        [When(@"I enter url (.*) and description (.*) and click on create button")]
        public void WhenIEnterUrlAndDescription(string url, string description)
        {
            _blogCreateView.Create(url, description);
        }

        [Then(@"I must be redirected on list of blog page")]
        public void ThenIMustBeRedirectedOnListOfBlogPage()
        {
            var result = _blogListView.IsAt();
            Assert.True(result, "The blog list view must be displayed");
        }

        [Then(@"my newly created blog will be displayed on that page")]
        public void ThenMyNewlyCreatedBlogWillBeDisplayedOnThatPage()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}