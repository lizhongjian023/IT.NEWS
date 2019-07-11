 
 
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
// T4模板自动生成   逻辑层
	
	public partial class CompanyService : BaseService<Company>, ICompanyService
    {
        public CompanyService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.CompanyDal;
        }
    }

	
	public partial class DepartmentService : BaseService<Department>, IDepartmentService
    {
        public DepartmentService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.DepartmentDal;
        }
    }

	
	public partial class LogAService : BaseService<LogA>, ILogAService
    {
        public LogAService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.LogADal;
        }
    }

	
	public partial class NewsService : BaseService<News>, INewsService
    {
        public NewsService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.NewsDal;
        }
    }

	
	public partial class NewsCommentsService : BaseService<NewsComments>, INewsCommentsService
    {
        public NewsCommentsService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.NewsCommentsDal;
        }
    }

	
	public partial class TestService : BaseService<Test>, ITestService
    {
        public TestService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.TestDal;
        }
    }

	
	public partial class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        public UserInfoService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.UserInfoDal;
        }
    }

	
	public partial class UserMSGService : BaseService<UserMSG>, IUserMSGService
    {
        public UserMSGService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.UserMSGDal;
        }
    }

	
	public partial class UsersService : BaseService<Users>, IUsersService
    {
        public UsersService(IDbSession DbSession) : base(DbSession)
        {
            this.CurrentDal = DbSession.UsersDal;
        }
    }

	
}

