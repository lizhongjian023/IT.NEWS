 
 
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{

	
 
	public  partial class CompanyDal : BaseDal<Company>, ICompanyDal
    {
    }

	
 
	public  partial class DepartmentDal : BaseDal<Department>, IDepartmentDal
    {
    }

	
 
	public  partial class LogADal : BaseDal<LogA>, ILogADal
    {
    }

	
 
	public  partial class NewsDal : BaseDal<News>, INewsDal
    {
    }

	
 
	public  partial class NewsCommentsDal : BaseDal<NewsComments>, INewsCommentsDal
    {
    }

	
 
	public  partial class TestDal : BaseDal<Test>, ITestDal
    {
    }

	
 
	public  partial class UserInfoDal : BaseDal<UserInfo>, IUserInfoDal
    {
    }

	
 
	public  partial class UserMSGDal : BaseDal<UserMSG>, IUserMSGDal
    {
    }

	
 
	public  partial class UsersDal : BaseDal<Users>, IUsersDal
    {
    }

	
}

