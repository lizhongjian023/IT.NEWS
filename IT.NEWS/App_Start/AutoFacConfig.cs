using Autofac;
using Autofac.Integration.Mvc;
using IT.NEWS.Bll;
using IT.NEWS.Dal;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;

namespace IT.NEWS.App_Start
{
    /// <summary>
    /// 用初始化AutoFac容器的相关数据
    /// </summary>
    public class AutoFacConfig
    {
        public static void Register()
        {
            //实例化一个autofac的创建容器
            var builder = new ContainerBuilder();

            //告诉Autofac框架，将来要创建的控制器类存放在哪个程序集 (AutoFacMvcDemo)
            Assembly controllerAss = Assembly.Load("IT.NEWS");
            builder.RegisterControllers(controllerAss);

            //如果有Dal层的话，注册Dal层的组件
            //告诉autofac框架注册数据仓储层所在程序集中的所有类的对象实例
            //Assembly dalAss = Assembly.Load("Dal");
            //创建respAss中的所有类的instance以此类的实现接口存储
            //builder.RegisterTypes(dalAss.GetTypes()).AsImplementedInterfaces();

            string assemService = ConfigurationManager.AppSettings["service"];

            
            //告诉autofac框架注册业务逻辑层所在程序集中的所有类的对象实例
            Assembly service = Assembly.Load(assemService);
            //创建serAss中的所有类的instance以此类的实现接口存储
            builder.RegisterTypes(service.GetTypes()).AsImplementedInterfaces();

            //   加载数据会话层访问实例
            string assemDbSession = ConfigurationManager.AppSettings["DBSession"];
            Assembly dbSession = Assembly.Load(assemDbSession);
            builder.RegisterTypes(dbSession.GetTypes()).AsImplementedInterfaces();

            //builder.RegisterType<UserInfoService>().As< IUserInfoService >().InstancePerDependency();
            //builder.RegisterType<DbSession>().As<IDbSession>().InstancePerDependency();
            //创建一个Autofac的容器
            var container = builder.Build();
            //将MVC的控制器对象实例 交由autofac来创建
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}