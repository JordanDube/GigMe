using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigMe.Startup))]
namespace GigMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
