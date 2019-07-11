using System.Web.Optimization;
using System.Web.Routing;
namespace HTGD.OA.UI.Portal
{
    public class MvcApplication : System.Web.HttpApplication   // Spring.Web.Mvc.SpringMvcApplication  //
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
