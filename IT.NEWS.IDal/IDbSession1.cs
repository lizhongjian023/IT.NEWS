 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.IDal
{

    /// <summary>
    /// 1.拥有所有Dal的实例
    /// </summary>
    public  partial interface IDbSession
    {
	    /// <summary>
        /// 拿到当前的上下文，把修改的实体进行整体的提交
        /// </summary>
        /// <returns></returns>
	
		 ICompanyDal  CompanyDal { get; set ;}
     
	
		 IDepartmentDal  DepartmentDal { get; set ;}
     
	
		 ILogADal  LogADal { get; set ;}
     
	
		 INewsDal  NewsDal { get; set ;}
     
	
		 INewsCommentsDal  NewsCommentsDal { get; set ;}
     
	
		 ITestDal  TestDal { get; set ;}
     
	
		 IUserInfoDal  UserInfoDal { get; set ;}
     
	
		 IUserMSGDal  UserMSGDal { get; set ;}
     
	
		 IUsersDal  UsersDal { get; set ;}
     
	}
}

