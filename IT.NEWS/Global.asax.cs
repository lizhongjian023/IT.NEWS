using Autofac;
using Autofac.Integration.Mvc;
using IT.NEWS.App_Start;
using IT.NEWS.Bll;
using IT.NEWS.IBll;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Windows.Forms;

namespace IT.NEWS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //从配偶之文件获取Log4x信息
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //  autofac 注入
             AutoFacConfig.Register();

            //var builder = new ContainerBuilder();
            //builder.RegisterType<UserInfoService>().As<IUserInfoService>();
            //builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}
