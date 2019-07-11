using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{
    public static  class SqlHelper
    {
        
            public static readonly string connstr =
                ConfigurationManager.ConnectionStrings["MsConStr"].ConnectionString;

        /// <summary>
        /// 返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql, CommandType type,SqlParameter []parameters)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql,con))
                {
                    adapter.SelectCommand.CommandType = type;
                    if (parameters != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(parameters);
                    }
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// 首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExcuteNoQuery(string sql, CommandType type  , SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    cmd.CommandType = type;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
