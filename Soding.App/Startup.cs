using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soding.App.Startup))]
namespace Soding.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
