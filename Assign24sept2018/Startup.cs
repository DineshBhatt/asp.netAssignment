using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign24sept2018.Startup))]
namespace Assign24sept2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
