using IT.NEWS.Dal;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using IT.NEWS.StaticDalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
    public partial class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        //EF_UserInfoDal userDal = new EF_UserInfoDal();

        //public int AddUserInfo(UserInfo userInfo)
        //{
        //    return userDal.Add(userInfo);
        //}

        //public UserInfoService(IDbSession DbSession) : base(DbSession)
        //{
        //    this.CurrentDal = DbSession.UserInfoDal;
        //}

     //   private IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();


        //public override void SetCurrentDal()
        //{
        //    this.CurrentDal = this.DbSession.EF_UserInfoDal;
        //}

    }
}
