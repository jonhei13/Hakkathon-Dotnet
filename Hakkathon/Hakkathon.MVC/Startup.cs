using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hakkathon.MVC.Startup))]
namespace Hakkathon.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
