using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuDynamicApp.Startup))]
namespace MenuDynamicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
