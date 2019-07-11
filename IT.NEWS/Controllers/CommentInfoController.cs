using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class CommentInfoController : BaseController
    {


        public ICompanyService CompanyService { get; set; }

        public IDbSession DBSession { get; set; }

        //public IUserInfoService UserInfoService = new UserInfoService(StaticDalFactory.DbSessionFactory.GetCurrentDbSession());

        public CommentInfoController(IDbSession dbSession, ICompanyService CompanyService)
        {
            this.DBSession = dbSession;
            this.CompanyService = CompanyService;
        }
        // GET: CommentInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(Company company)
        {


            company = new Company
            {
                CId = 1,
                CName = "晨会",
                UserInfoId = "122"
            };
            CompanyService.Add(company);
            return Content("ok：hello");

        }
    }
}