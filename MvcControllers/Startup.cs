using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcControllers.Startup))]
namespace MvcControllers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
