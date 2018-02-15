using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LBC_WebSite.Startup))]
namespace LBC_WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
