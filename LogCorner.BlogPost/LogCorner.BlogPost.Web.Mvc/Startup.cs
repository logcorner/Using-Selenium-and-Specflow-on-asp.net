using BlogPostMvc;
using LogCorner.BlogPost.Web.Mvc.Mapping;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Startup))]

namespace BlogPostMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MappBlog();
        }
    }
}