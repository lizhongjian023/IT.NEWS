using IT.NEWS.Bll;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        //约定大于配置
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            string valigateCode = Session["code"] == null ? string.Empty : Session["code"].ToString();
            if (string.IsNullOrEmpty(valigateCode))
            {
                return Content("no:验证码不能为空！");
            }
            Session["code"] = null;
            string txtCode = Request["vCode"];
            //  忽略大小写
            if (!valigateCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
            {
                return Content("no:验证码错误！");
            }
            string userName = Request["LoginCode"];
            string userPwd = Request["LoginPwd"];

            // 后台获取用户数据
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo = userInfoService.GetUserInfo(userName, userPwd);
            if (userInfo != null)
            {
                Session["userInfo"] = userInfo;
                return Content("ok:登录成功！");
            }
            else
            {
                return Content("no:登录失败！");
            }
         


        }

        public ActionResult ShowValidateCode()
        {
            Common.ValidateCode validate = new Common.ValidateCode();
            string code = validate.CreateValidateCode(4);  //获取验证码
            Session["code"] = code;  //存入到session
            byte[] buffer = validate.CreateValidateGraphic(code);   //将验证码画在图上
            return File(buffer, "image/jpeg");
        }
    }
}