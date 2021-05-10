using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustGoTravel.MVC.Startup))]
namespace JustGoTravel.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
