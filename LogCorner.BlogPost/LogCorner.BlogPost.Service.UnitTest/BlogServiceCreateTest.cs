using NUnit.Framework;

namespace LogCorner.BlogPost.Service.UnitTest
{
    [TestFixture(Description = "user must be loggedin first to create a blog Post")]
    public class BlogServiceCreateTest
    {
        [Test(Description = "When No Authenticated User Create A BlogPost Must Restunr Unautorised")]
        public void WhenNoAuthenticatedUserCreateABlogPostMustRestunrUnautorised()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test(Description = "When Authenticated User Create A BlogPost Must Resturn OK")]
        public void WhenAuthenticatedUserCreateABlogPostMustResturnOk()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}