using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aerodrom.Startup))]
namespace Aerodrom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
