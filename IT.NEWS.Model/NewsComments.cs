using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Model
{
    public class NewsComments

    {
        public int Id
        { get; set; }
        /// <summary>
        /// 新闻Id
        /// </summary>
        public string NewsId
        { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public string Msg
        { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CrDateTime
        {
            get; set;
        }



    }
}
