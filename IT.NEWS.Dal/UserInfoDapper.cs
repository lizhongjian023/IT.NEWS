using Dapper;
using IT.NEWS.Common;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{
    public class UserInfoDapper
    {

        /// <summary>
        /// 获取UserInfo
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public IEnumerable<UserInfo> GetUserInfoByDapper(UserInfo userInfo)
        {
            string sql = "select ID,  [UserName],[UserLoginName],[UserPsd],[IsOnline],[IsUseful],[UserRealName],[UserMail] from UserInfo where UserLoginName = @UserLoginName  and UserPsd = @UserPsd";

            using (var con = DapperDataHelper.GetDbConnection())
            {
                return con.Query<UserInfo>(sql,userInfo);
            }
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <returns></returns>
        public int AddUserInfo( UserInfo userInfo)
        {
            string sql = " INSERT INTO [dbo].[UserInfo]  ([UserName],[UserLoginName],[UserPsd],[IsOnline],[IsUseful],[UserRealName],[UserMail])" +
                "VALUES(@UserName, @UserLoginName, @UserPsd, @IsOnline, @IsUseful, @UserRealName, @UserMail)";
            using (var conn = DapperDataHelper.GetDbConnection())
            {
                return conn.Execute(sql,userInfo);
            }
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int UpdateUserInfo(UserInfo userInfo)
        {
            string sql = " Update UserInfo set [UserName] = @UserInfo,[UserLoginName] = @UserLoginName,[UserPsd] = @UserPsd,[IsOnline] = @IsOnline,[IsUseful] = @IsUseful,[UserRealName] = @UserRealName,[UserMail] =  @UserMail  where id = @id ";
            using (var conn = DapperDataHelper.GetDbConnection())
            {
                return conn.Execute(sql, userInfo);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public int DeleteUserInfo(UserInfo userInfo)
        {
            string sql = "delete from UserInfo   where id = @id ";
            using (var conn = DapperDataHelper.GetDbConnection())
            {
                return conn.Execute(sql, userInfo);
            }
        }


    }
}
