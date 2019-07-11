using IT.NEWS.IBll;
using IT.NEWS.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users

        IUsersService UsersService { get; set; }
        IDbSession DbSession { get; set; }

        public UsersController(IUsersService _usersService, IDbSession _dbSession)
        {
            this.DbSession = _dbSession;
            this.UsersService = _usersService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUsers()
        {
            var userList =  UsersService.GetModels(p => p.Id > 0);
            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add()
        {
            var userList = UsersService.Add(new Model.Users { Address = "海信大道", LoginId = "lizj", Number = "123456789", Name = "CL", Password = "aaaa", UserId = 1236 });
            return Json(userList, JsonRequestBehavior.AllowGet);
        }
    }
}