using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnMVC2.Web.Startup))]
namespace LearnMVC2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
