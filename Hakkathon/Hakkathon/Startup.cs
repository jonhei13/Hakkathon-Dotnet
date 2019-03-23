using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hakkathon.Startup))]
namespace Hakkathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
