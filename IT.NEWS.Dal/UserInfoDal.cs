using IT.NEWS.Dal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
    public class UserInfoDal
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPsd"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(string userName ,string userPsd)
        {
            string sql = "select *from UserInfo where UserLoginName = @userName and UserPsd = @userPsd";
            // 添加参数
            SqlParameter[] parameters = {
                 new SqlParameter("@userName",System.Data.SqlDbType.NVarChar,64),
                 new SqlParameter("@userPsd",System.Data.SqlDbType.NVarChar,64),       
              };
            parameters[0].Value = userName;
            parameters[1].Value = userPsd;

          DataTable dt =  SqlHelper.GetTable(sql, System.Data.CommandType.Text, parameters);
            UserInfo userInfo = null;
            if(dt.Rows.Count>0)
            {
                userInfo = new UserInfo();
                LoadEntity(userInfo, dt.Rows[0]);
            }
            return userInfo;
        }

        private void LoadEntity(UserInfo userInfo, DataRow dataRow)
        {
            userInfo.Id = Convert.ToInt32(dataRow["Id"]);
            userInfo.UserLoginName = dataRow["UserLoginName"] != DBNull.Value ? dataRow["UserLoginName"].ToString() : string.Empty;
            userInfo.UserPsd = dataRow["UserPsd"] != DBNull.Value ? dataRow["UserPsd"].ToString() : string.Empty;
            userInfo.UserMail = dataRow["UserMail"] != DBNull.Value ? dataRow["UserMail"].ToString() : string.Empty;
            userInfo.UserName = dataRow["UserName"] != DBNull.Value ? dataRow["UserName"].ToString() : string.Empty;

        }
    }
}
