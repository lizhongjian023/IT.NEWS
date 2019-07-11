using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Model
{
    public class News
    {
        public int Id
        { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>


        public string NewsMsg
        {
            get; set;
        }
        public DateTime SubTime
        {
            get; set;
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            get; set;
        }

        // 图片地址
        public string ImagePath
        {
            get; set;
        }
    }
}
