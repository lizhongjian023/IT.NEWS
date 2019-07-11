 
 
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.IBll
{

	  
	public partial interface ICompanyService : IBaseService<Company>
    {
    }

	  
	public partial interface IDepartmentService : IBaseService<Department>
    {
    }

	  
	public partial interface ILogAService : IBaseService<LogA>
    {
    }

	  
	public partial interface INewsService : IBaseService<News>
    {
    }

	  
	public partial interface INewsCommentsService : IBaseService<NewsComments>
    {
    }

	  
	public partial interface ITestService : IBaseService<Test>
    {
    }

	  
	public partial interface IUserInfoService : IBaseService<UserInfo>
    {
    }

	  
	public partial interface IUserMSGService : IBaseService<UserMSG>
    {
    }

	  
	public partial interface IUsersService : IBaseService<Users>
    {
    }

	
}

