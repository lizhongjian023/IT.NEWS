 
 
using IT.NEWS.Dal;
using IT.NEWS.DapperDal;
using IT.NEWS.IDal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.StaticDalFactory
{
    /// <summary>
    /// 抽象工厂封装数据操作类实例创建，然后DBSession调用抽象工厂，修改DBSession
    /// DALFactory数据会话层调数据层不能直接new,要封装一下解耦
    /// </summary>
    public partial class StaticDalFactory
    {
        /// <summary>
        /// 获取程序集配置
        /// </summary>
        static readonly string assemblyName = ConfigurationManager.AppSettings["Factory"];

	
		public static ICompanyDal GetCompanyDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".CompanyDal") as ICompanyDal;
        }

	
		public static IDepartmentDal GetDepartmentDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".DepartmentDal") as IDepartmentDal;
        }

	
		public static ILogADal GetLogADal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".LogADal") as ILogADal;
        }

	
		public static INewsDal GetNewsDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".NewsDal") as INewsDal;
        }

	
		public static INewsCommentsDal GetNewsCommentsDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".NewsCommentsDal") as INewsCommentsDal;
        }

	
		public static ITestDal GetTestDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".TestDal") as ITestDal;
        }

	
		public static IUserInfoDal GetUserInfoDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserInfoDal") as IUserInfoDal;
        }

	
		public static IUserMSGDal GetUserMSGDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserMSGDal") as IUserMSGDal;
        }

	
		public static IUsersDal GetUsersDal()
        {
             return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UsersDal") as IUsersDal;
        }

	}
}

