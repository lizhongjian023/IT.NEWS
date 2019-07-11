using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Common
{
    public static  class DapperDataHelper
    {
        public static readonly string connstr =
               ConfigurationManager.ConnectionStrings["MsConStr"].ConnectionString;
        public static IDbConnection GetDbConnection( )
        {
              

            return new SqlConnection(connstr);
            //if (conStr != null)
            //{
            //return new SqlConnection (conStr);
            // }
            //else
            //{
            //    // 抛日志  记录配置新未获取到

            //    Log4Helper.WriteFatal("Sql字符串连接出错");

            //    return null;
            //}

        }
    }
}
