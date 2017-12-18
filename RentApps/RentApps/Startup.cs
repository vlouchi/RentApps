using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentApps.Startup))]
namespace RentApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
