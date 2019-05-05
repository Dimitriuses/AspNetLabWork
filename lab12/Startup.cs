using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab12.Startup))]
namespace lab12
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
