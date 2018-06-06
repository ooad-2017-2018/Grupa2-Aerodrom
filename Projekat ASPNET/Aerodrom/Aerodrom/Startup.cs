using Aerodrom.Models;
using Microsoft.Owin;
using Owin;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

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
