using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finder.Startup))]
namespace Finder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
