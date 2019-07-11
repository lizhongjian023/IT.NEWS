using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.DapperDal 
{
    public class NewsInfo
    {

        ///// <summary>
        /////获取新闻列表
        ///// </summary>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <returns></returns>
        //public  List<News> GetNewsList(int start,int end)
        //{
        //    string sql = " select * from (select row_number() over (order by id ) as num,id,[Title] ,[SubTime] ,[Author]   ,[ImagePath] ,[NewsMsg] from News ) as T where t.num >@start and T.num <=@end";

        //    //dapper    声明sql  变量
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@start", start, DbType.Int32);
        //    parameters.Add("end", end, DbType.Int32);
                
                
        //    //    SqlParameter[] sqlParameters = {
        //    //    new SqlParameter("@start",SqlDbType.Int,start ) ,
        //    //    new SqlParameter("@end",SqlDbType.Int,end )
        //    //};
        //    using (var conn = DapperDataHelper.GetDbConnection())
        //    {
        //      return   conn.Query<News>(sql, parameters).ToList() ;
        //    }

        //}

        ///// <summary>
        ///// 新增新闻
        ///// </summary>
        ///// <param name="news"></param>
        ///// <returns></returns>
        //public int AddNews(News news)
        //{
        //    string sql = "insert into News " +
        //        "([Title] ,[SubTime] ,[Author]   ,[ImagePath] ,[NewsMsg])values (@Title,@SubTime,@Author,@ImagePath,@NewsMsg)";
        //    using (var conn = DapperDataHelper.GetDbConnection())
        //    {
        //        return conn.Execute(sql, news);
        //    }
        //}

        //public int DeleteNews(int id)
        //{
        //    string sql = "delete from News where id = @id";
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@id",id);
        //    using (var conn = DapperDataHelper.GetDbConnection())
        //    {
        //        return conn.Execute(sql,parameters);
        //    }
        //}

        ///// <summary>
        ///// 更改新闻信息
        ///// </summary>
        ///// <param name="news"></param>
        ///// <returns></returns>
        //public int UpdateNews(News news)
        //{
        //    string sql = "update News set Title=@Title,SubTime =@SubTime,Author = @Author,ImagePath = @ImagePath,NewsMsg = @NewsMsg where id = @id";
        //    using (var con = DapperDataHelper.GetDbConnection())
        //    {
        //        return con.Execute(sql,news);
        //    }
        //}

        ///// <summary>
        ///// 返回数据总记录数
        ///// </summary>
        ///// <returns></returns>
        //public static int GetRecordCount()
        //{
        //    string sql = "select count(1) from news";
        //    using (var conn = DapperDataHelper.GetDbConnection())
        //    {
        //        return conn.ExecuteScalar<int>(sql);
        //    }
        //}

        ///// <summary>
        ///// 获取新闻详细信息
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public News GetNewsInfo(int id)
        //{
        //    string sql = "select id,[Title] ,[SubTime] ,[Author]   ,[ImagePath] ,[NewsMsg] from News where id = @id";
        //    using (var conn = DapperDataHelper.GetDbConnection())
        //    {

        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@id", id);
        //        List<News> news =  conn.Query<News>(sql, parameters).ToList();
        //        News newInfo = new News();
        //        foreach (var list in news)
        //        {
        //            newInfo.Author = list.Author;
        //            newInfo.Id = list.Id;
        //            newInfo.ImagePath = list.ImagePath;
        //            newInfo.NewsMsg = list.NewsMsg;
        //            newInfo.SubTime = list.SubTime;
        //            newInfo.Title = list.Title;
        //        }
        //        return newInfo;
        //    }
        //}
    }
}
