using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLAPI.Startup))]
namespace QLAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
