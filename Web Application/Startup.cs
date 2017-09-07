using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign9.Startup))]
namespace Assign9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
