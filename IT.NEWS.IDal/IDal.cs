 
 
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.IDal
{

	  
	public partial interface ICompanyDal : IBaseDal<Company>
    {
       
    }

	  
	public partial interface IDepartmentDal : IBaseDal<Department>
    {
       
    }

	  
	public partial interface ILogADal : IBaseDal<LogA>
    {
       
    }

	  
	public partial interface INewsDal : IBaseDal<News>
    {
       
    }

	  
	public partial interface INewsCommentsDal : IBaseDal<NewsComments>
    {
       
    }

	  
	public partial interface ITestDal : IBaseDal<Test>
    {
       
    }

	  
	public partial interface IUserInfoDal : IBaseDal<UserInfo>
    {
       
    }

	  
	public partial interface IUserMSGDal : IBaseDal<UserMSG>
    {
       
    }

	  
	public partial interface IUsersDal : IBaseDal<Users>
    {
       
    }

	
}

