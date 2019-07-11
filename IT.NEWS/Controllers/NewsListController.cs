using IT.NEWS.Bll;
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
    public class NewsListController : BaseController
    {
        // GET: NewsList


        //NewsService newsService = new NewsService();
        //public ActionResult Index()
        //{

        //    //  页码条数
        //    int pageSize = 10;

        //    // 第几页
        //    int pageIndex = Request["pageIndex"] != null ? int.Parse(Request["pageIndex"]) +1: 1;

        //    //  页数
        //    int pageCount = NewsService.GetPageCont(pageSize);
        //    pageIndex = pageIndex < 1 ? 1 : pageIndex;
        //    pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
        //    List<News> newsList = newsService.GetNews(pageIndex,pageSize);

        //    ViewData["newsList"] = newsList;
        //    ViewBag.PageIndex = pageIndex;
        //    ViewBag.PageCount = pageCount;
        //    return View();
        //}

        ///// <summary>
        ///// 新闻详情
        ///// </summary>
        ///// <returns></returns>
        //public ActionResult ShowDetail()
        //{
        //    int id = int.Parse(Request["id"]);
        //    News news = newsService.GetNewsDetail(id);

        //    ViewData.Model = news;
        //    return View();
        //}


        INewsService NewsService { get; set; }
        IDbSession DbSession { get; set; }

        public NewsListController( INewsService newsService,IDbSession dbSession)
        {
            this.NewsService = newsService;
            this.DbSession = dbSession;
        }
        public ActionResult Add()
        {
            var news = new News { Title = "智障专用", Author = "cl", ImagePath = "hello", NewsMsg = "1290dgwstrsdgfsgfsd", SubTime = DateTime.Now.ToString() };
            var result = NewsService.Add(news);
            return Content("ok:添加成功");
        }
    }
}