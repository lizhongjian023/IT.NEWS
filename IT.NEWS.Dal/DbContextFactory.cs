using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{
    public static class DbContextFactory
    {
        /// <summary>
        /// 获取当前上下文,负责创建EF数据操作上下文实例，必须保证线程内唯一
        /// </summary>
        /// <returns></returns>
        public static  DbContext GetDbContext()
        {
            DbContext db = CallContext.GetData("HT_NewsEntities") as DbContext;
            if (db == null)
            {
                db = new HT_NewsEntities();
                CallContext.SetData("HT_NewsEntities", db);
            }
            return db;
        }
    }
}
