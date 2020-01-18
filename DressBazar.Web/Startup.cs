using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DressBazar.Web.Startup))]
namespace DressBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
