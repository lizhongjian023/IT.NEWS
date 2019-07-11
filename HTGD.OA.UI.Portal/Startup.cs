using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTGD.OA.UI.Portal.Startup))]
namespace HTGD.OA.UI.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
