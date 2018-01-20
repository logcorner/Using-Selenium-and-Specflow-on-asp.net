using LogCorner.BlogPost.Web.Mvc.UITest.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace LogCorner.BlogPost.Web.Mvc.UITest.Steps
{
    [Binding]
    public class HomeViewSteps
    {
        private HomeView _homeView;
        private BlogListView _blogListView;

        public HomeViewSteps(HomeView homeView, BlogListView blogListView)
        {
            _homeView = homeView;
            _blogListView = blogListView;
        }

        [Given(@"I am on the BlogPost application home page")]
        public void GivenIAmOnTheBlogPostApplicationHomePage()
        {
            _homeView.Goto();
        }

        [Then(@"Verify that the page title is (.*)")]
        public void ThenVerifyThePageTitle(string title)
        {
            Assert.IsTrue(title == _homeView.Title, "The page title is not correct");
        }
    }
}