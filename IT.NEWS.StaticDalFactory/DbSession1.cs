 
 
using IT.NEWS.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{
	  /// <summary>
    /// 1.数据会话层：就是一个工厂类，负责完成所有数据操作类实例的创建，然后业务层通过数据会话层来获取要操作数据类的实例，
    /// 所以数据会话层将业务层和数据层解耦。
    /// 2.在数据会话层中提供一个方法：完成所有数据的保存。
    /// </summary>
	public partial class DbSession : IDbSession
    {

	    /// <summary>
        /// 拿到当前的上下文，把修改的实体进行整体的提交
        /// </summary>
        /// <returns></returns>
        public  int SaveChanges()
        {
            //  获取当前上下文   保存
            return DbContextFactory.GetDbContext().SaveChanges();
        }
	
		ICompanyDal IDbSession.CompanyDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetCompanyDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		IDepartmentDal IDbSession.DepartmentDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetDepartmentDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		ILogADal IDbSession.LogADal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetLogADal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		INewsDal IDbSession.NewsDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetNewsDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		INewsCommentsDal IDbSession.NewsCommentsDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetNewsCommentsDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		ITestDal IDbSession.TestDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetTestDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		IUserInfoDal IDbSession.UserInfoDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetUserInfoDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		IUserMSGDal IDbSession.UserMSGDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetUserMSGDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	
		IUsersDal IDbSession.UsersDal
        {
            get 
			{
				return StaticDalFactory.StaticDalFactory.GetUsersDal();
			}

            set
            {
                throw new NotImplementedException();
            }
         }

	}
}

