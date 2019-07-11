using Microsoft.VisualStudio.TestTools.UnitTesting;
using IT.NEWS.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.NEWS.Model;
using IT.NEWS.Common;

namespace IT.NEWS.Bll.Tests
{
    [TestClass()]
    public class UserInfoServiceTests
    {
        [TestMethod()]
        public void GetUserInfoByDapperTest()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.IsOnline = 1;
            userInfo.IsUseful = 1;
            userInfo.UserLoginName = "Lizj";
            userInfo.UserMail = "153126453@qq.com";
            userInfo.UserName = "李中建";
            userInfo.UserPsd = MD5Helper.GetMD5("123456");
            userInfo.UserRealName = "瓜皮";

            UserInfoService userInfoService = new UserInfoService();
           var user =  userInfoService.GetUserInfoByDapper(userInfo);
            if (user.Count() > 0)
            {
            }
            else
            {
                Assert.Fail();
            }
            
        }

        [TestMethod()]
        public void AddUserInfoTest()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.IsOnline = 1;
            userInfo.IsUseful = 1;
            userInfo.UserLoginName = "Lizj";
            userInfo.UserMail = "153126453@qq.com";
            userInfo.UserName = "李中建";
            userInfo.UserPsd = MD5Helper.GetMD5("123456");
            userInfo.UserRealName = "瓜皮";

            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.AddUserInfo(userInfo))
            {
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}