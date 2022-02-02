using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheAuroraResort.Startup))]
namespace TheAuroraResort
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
