using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Model
{
    public class UserInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id
        { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        { get; set; }
        /// <summary>
        /// 用户登陆名
        /// </summary>
        public string UserLoginName
        { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPsd
        {
            get; set;
        }

        // 是否在线   0：否  1 ： 是
        public int IsOnline
        {
            get; set;
        }

        /// <summary>
        /// 是否有效 true  有
        /// </summary>
        public int IsUseful
        {
            get; set;
        }
        /// <summary>
        /// 用户真实名
        /// </summary>
        public string UserRealName
        {
            get; set;
        }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserMail
        {
            get; set;
        }
    }
}
