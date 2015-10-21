using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleMvcWeb.Startup))]
namespace SimpleMvcWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
