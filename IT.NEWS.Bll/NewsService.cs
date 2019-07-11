using IT.NEWS.Dal;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;

namespace IT.NEWS.Bll
{
    public partial class NewsService : BaseService<News>,INewsService 
    {

        //public NewsService(IDbSession DbSession) : base(DbSession)
        //{
        //    this.CurrentDal = DbSession.NewsDal;
        //}


        //  NewsInfo newsInfo = new NewsInfo();
        ////  News news = new News();
        ///// <summary>
        ///// 加载新闻列表
        ///// </summary>
        ///// <param name="pageIndex">当前页</param>
        ///// <param name="pageSize">每页显示的记录数</param>
        ///// <returns></returns>
        //  public List<News> GetNews(int pageIndex,int pageSize )
        //  {
        //      int strat = (pageIndex - 1) * pageSize + 1;
        //      int end = pageIndex * pageSize;

        //      return newsInfo.GetNewsList(strat, end);
        //  }

        //  /// <summary>
        //  /// 更新新闻
        //  /// </summary>
        //  /// <param name="news"></param>
        //  /// <returns></returns>
        //  public bool UpdareNews( News news)
        //  {
        //      return newsInfo.UpdateNews(news) > 0 ? true : false;
        //  }
        //  public bool AddNews(News news)
        //  {
        //      return newsInfo.AddNews(news) > 0 ? true : false;
        //  }
        //  /// <summary>
        //  /// 获取总的页数   
        //  /// </summary>
        //  /// <param name="pageSize">  每页的大小</param>
        //  /// <returns></returns>
        //  public static int GetPageCont(int pageSize)
        //  {
        //      int recordCount = NewsInfo.GetRecordCount();
        //      int pageCount = Convert.ToInt32(Math.Ceiling((double)recordCount / pageSize));
        //      return pageCount;
        //  }
        //  /// <summary>
        //  /// 新闻详情
        //  /// </summary>
        //  /// <param name="id"></param>
        //  /// <returns></returns>
        //  public News GetNewsDetail(int id)
        //  {
        //      return newsInfo.GetNewsInfo(id);
        //  }

        //  /// <summary>
        //  /// 删除新闻
        //  /// </summary>
        //  /// <param name="id"></param>
        //  /// <returns></returns>
        //  public bool DeteNews(int id)
        //  {
        //      return newsInfo.DeleteNews(id) > 0 ? true : false;
        //  }

    }
}