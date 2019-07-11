using IT.NEWS.Bll;
using IT.NEWS.Dal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class AdminNewInfoController : BaseController
    {
        // GET: AdminNewList


        //NewsService newsService = new NewsService();
        ///// <summary>
        ///// 分页列表
        ///// </summary>
        ///// <returns></returns>
        //public ActionResult Index()
        //{
        //    int pageIndex = Request["pageIndex"] != null ? int.Parse(Request["pageIndex"]) : 1;
        //    int pageSize = 5;
        //    int pageCount = NewsService.GetPageCont(pageSize);
        //    pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
        //    //获取分页数据
        //    List<News> newsList = newsService.GetNews(pageIndex, pageSize);

        //    ViewData["newsList"] = newsList;
        //    ViewBag.PageIndex = pageIndex;
        //    ViewBag.PageCount = pageCount;
        //    return View();
        //}


        //#region   获取详细页
        //public ActionResult GetNewInfoModel()
        //{
        //    int id = Request["id"] != null ? int.Parse(Request["id"]) : 1;
        //    News newsInfo = newsService.GetNewsDetail(id);   // 新闻详细

        //    return Json(newsInfo, JsonRequestBehavior.AllowGet);  //json 形式返回
        //}

        //#endregion


        //#region  显示添加信息的表单界面
        //public ActionResult ShowAddInfo()
        //{
        //    //int id = Request["id"] != null ? int.Parse(Request["id"]) : 1;
        //    //newsService.AddNews(id);
        //    return View();
        //}
        //#endregion


        //#region 删除选中新闻

        //public ActionResult DeleteNewInfo()
        //{
        //    int id = int.Parse(Request["id"]);
        //    if (newsService.DeteNews(id))
        //    {
        //        return Content("ok");
        //    }
        //    else
        //    {
        //        return Content("no");
        //    }
        //}

        //#endregion



        //#region  添加信息

        //[ValidateInput(false)]
        //public ActionResult AddNewInfo(News news)
        //{
        //    //news.SubTime = DateTime.Now;
        //    //if (newsService.AddNews(news))
        //    //{
        //    //    return Content("ok");
        //    //}
        //    //else
        //    //{
        //    //    return Content("no");
        //    //}
        //    return null;
        //}
        //#endregion


        //#region  文件上传
        //public ActionResult FileUpLoad()
        //{
        //    HttpPostedFileBase postedFile = Request.Files["dileUp"];

        //    if (postedFile == null)
        //    {
        //        return Content("no:请选择上传文件");
        //    }
        //    else
        //    {
        //        string fileName = Path.GetFileName(postedFile.FileName);  //获取文件名称

        //        string fileEXT = Path.GetExtension(postedFile.FileName);  //文件扩展名

        //        if (fileEXT == ".jpg")
        //        {
        //            //   按照年月日新建文件夹
        //            string dir = "/ImagePath/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Date;
        //            Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));   //创建文件夹

        //            string newFileName = Guid.NewGuid().ToString(); //新名字

        //            string fullDir = dir + fileName + fileEXT;  //完整路径

        //            postedFile.SaveAs(Request.MapPath(fullDir));  //保存文件
        //            return Content("ok:"+fullDir);

        //        }
        //        else
        //        {
        //            return Content("no:文件类型不对！");
        //        }

        //    }


        //}
        //#endregion


    }
}