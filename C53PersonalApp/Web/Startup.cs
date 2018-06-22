using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C53PersonalApp.Web.Startup))]
namespace C53PersonalApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
