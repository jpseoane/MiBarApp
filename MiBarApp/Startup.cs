using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiBarApp.Startup))]
namespace MiBarApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
