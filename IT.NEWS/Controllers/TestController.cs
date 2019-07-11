using IT.NEWS.Cache.Base;
using IT.NEWS.Cache.Factory;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class TestController : Controller
    {
         public ITestService TestService { get; set; }

        public IDbSession DBSession { get; set; }

        //public IUserInfoService UserInfoService = new UserInfoService(StaticDalFactory.DbSessionFactory.GetCurrentDbSession());

        public TestController(IDbSession dbSession, ITestService _testService)
        {
            this.DBSession = dbSession;
            this.TestService = _testService;
        }
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTest()
        {
            TestService.Add(new Model.Test { Name = "dd", Test1 = "131333",ID = Guid.NewGuid().ToString() });

            var data = TestService.GetModels(p => true);
            ICache cache = CacheFactory.CaChe();
            cache.Write("TestData","aaaaaaaaaaaaaaaaaaaaa",0);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}