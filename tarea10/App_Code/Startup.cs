using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tarea10.Startup))]
namespace tarea10
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
