using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pond.Web.Startup))]
namespace Pond.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
