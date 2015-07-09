using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebAPI.Startup))]
namespace GitWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
