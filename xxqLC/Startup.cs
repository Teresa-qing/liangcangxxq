using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xxqLC.Startup))]
namespace xxqLC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
