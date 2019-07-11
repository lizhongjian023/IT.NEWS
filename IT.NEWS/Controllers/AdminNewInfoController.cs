using IT.NEWS.Bll;
using IT.NEWS.Dal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class AdminNewInfoController : Controller
    {
        // GET: AdminNewList


        NewsService newsService = new NewsService();
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            int pageIndex = Request["pageIndex"] != null ? int.Parse(Request["pageIndex"]) : 1;
            int pageSize = 5;
            int pageCount = NewsService.GetPageCont(pageSize);
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            //获取分页数据
            IEnumerable< News> newsList = newsService.GetNews(pageIndex,pageSize);

            ViewData["newsList"] = newsList;

            return View();
        }


        #region   获取详细页
        public ActionResult GetNewInfoModel()
        {
            int id = int.Parse(Request["id"]);
            IEnumerable<News> newsInfo = newsService.GetNewsDetail(id);   // 新闻详细

            return
                Json(newsInfo, JsonRequestBehavior.AllowGet);  //json 形式返回
        }

        #endregion



    }
}