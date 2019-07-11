using IT.NEWS.Bll;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using IT.NEWS.StaticDalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class UserInfoController : Controller
    {
        public IUserInfoService UserInfoService { get; set; }

        public IDbSession DBSession { get; set; }

        //public IUserInfoService UserInfoService = new UserInfoService(StaticDalFactory.DbSessionFactory.GetCurrentDbSession());

        public UserInfoController(IDbSession dbSession,IUserInfoService userInfoService)
        {
            this.DBSession = dbSession;
            this.UserInfoService = userInfoService;
        }

        // GET: UserInfo
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Add( UserInfo userinfo)
        {
            userinfo = new UserInfo
            {
                Age = 24,
                CId = 111,
                Company = "Hisense",
                Department = "综合管理",
                Name = "PW",
                WorkCode = 1234567
            };
            UserInfoService.Add(userinfo);
            return Content("ok：hello");
        }
        public ActionResult GetList()
        {
          var datas =   UserInfoService.GetModels(p => p.Id > 20);
            return Json(datas,JsonRequestBehavior.AllowGet);
        }
    }
}