using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHelpers.Startup))]
namespace WebHelpers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
