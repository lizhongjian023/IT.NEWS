using IT.NEWS.Dal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;

namespace IT.NEWS.Bll
{
    public  class NewsService
    {

        NewsInfo newsInfo = new NewsInfo();
      //  News news = new News();
      /// <summary>
      /// 
      /// </summary>
      /// <param name="pageIndex">当前页</param>
      /// <param name="pageSize">每页显示的记录数</param>
      /// <returns></returns>
        public IEnumerable<News> GetNews(int pageIndex,int pageSize )
        {
            int strat = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            return newsInfo.GetNewsList(strat, end);
        }

        public bool UpdareNews( News news)
        {
            return newsInfo.UpdateNews(news)>0?true:false;
        }
        public bool AddNews(News news)
        {
            return newsInfo.AddNews(news)>0?true:false;
        }
        /// <summary>
        /// 获取总的页数   
        /// </summary>
        /// <param name="pageSize">  每页的大小</param>
        /// <returns></returns>
        public static int GetPageCont(int pageSize)
        {
            int recordCount = NewsInfo.GetRecordCount();
            int pageCount = Convert.ToInt32(Math.Ceiling((double)recordCount / pageSize));
            return pageCount;
        }
        /// <summary>
        /// 新闻详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  IEnumerable<News> GetNewsDetail(int id)
        {
            return newsInfo.GetNewsInfo(id);
        }
    }
}