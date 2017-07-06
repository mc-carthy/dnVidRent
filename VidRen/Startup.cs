using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidRen.Startup))]
namespace VidRen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
