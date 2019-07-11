using Microsoft.VisualStudio.TestTools.UnitTesting;
using IT.NEWS.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.NEWS.StaticDalFactory;
using IT.NEWS.Dal;

namespace IT.NEWS.Bll.Tests
{
    [TestClass()]
    public class EF_UserInfoServiceTests
    {
        [TestMethod()]
        public void AddUserInfoTest()
        {
            //---------------------保存实例-----------------------------

            //  EF_UserInfoService userInfoService = new EF_UserInfoService();

            var info = new Model.UserInfo
            {
                Company = "Hisen_Dapper_ce_Test",
                Age = 12,
                Name = "Hisense-N-T-V-W",
                WorkCode = 201910901,
                CId = 212,
                Department = "信、SDff"
            };
            StaticDalFactory.DbSessionFactory.GetCurrentDbSession();
            UserInfoService userInfoService = new UserInfoService(StaticDalFactory.DbSessionFactory.GetCurrentDbSession());
            userInfoService.Add(info);


            //int resultDal = dal.Add(info);
            //  StaticDalFactory.DbSessionFactory.GetCurrentDbSession().EF_UserInfoDal.Add(info);

            //var dal = StaticDalFactory.DbSessionFactory.GetCurrentDbSession().EF_UserInfoDal;

            //var a = dal.Add(info);

            //int ss = StaticDalFactory.DbSessionFactory.GetCurrentDbSession().SaveChanges();

            //if (ss > 0)
            //{
            //}
            //else
            //{
            //    Assert.Fail();
            //}

        }

        [TestMethod()]
        public void EF_UserInfoServiceTest()
        {
            Assert.Fail();
        }
    }
}