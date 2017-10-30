using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebApp1.Startup))]
namespace GitWebApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
