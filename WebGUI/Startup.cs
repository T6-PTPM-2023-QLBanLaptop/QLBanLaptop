using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGUI.Startup))]
namespace WebGUI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
