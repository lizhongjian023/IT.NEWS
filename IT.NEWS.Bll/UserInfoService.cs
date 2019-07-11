using IT.NEWS.Dal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
    public class UserInfoService
    {
        UserInfoDal userInfoDal = new UserInfoDal();

        UserInfoDapper userInfoDapper = new UserInfoDapper();

        public UserInfo GetUserInfo(string userName, string userPsd)
        {
            return userInfoDal.GetUserInfo(userName, userPsd);

        }

        public IEnumerable<UserInfo>   GetUserInfoByDapper(UserInfo userInfo)
        {
            return userInfoDapper.GetUserInfoByDapper(userInfo);
        }

        /// <summary>
        ///   新增  
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfo userInfo)
        {
            return userInfoDapper.AddUserInfo(userInfo)>0?true:false;
        }

    }
}
