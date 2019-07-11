using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Dal
{
    public class BaseDal<T> where T : class, new()
    {
        // HT_NewsEntities dmc_var = new HT_NewsEntities();

        /// <summary>
        /// 本次访问的上下文
        /// </summary>
        public DbContext dmc
        {
            get
            {
                return DbContextFactory.GetDbContext();
            }
        }
        public int Add(T t)
        {
            dmc.Entry(t).State = System.Data.Entity.EntityState.Added;
            return dmc.SaveChanges();
        }

        public int Update(T t)
        {
            dmc.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return dmc.SaveChanges();
        }

        public int Detele(T t)
        {
            dmc.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return dmc.SaveChanges();
        }

        public T GetModel(Func<T, bool> wherLambda)
        {
            return dmc.Set<T>().Where(wherLambda).FirstOrDefault();
        }

        public IQueryable< T > GetList(Expression <Func<T,bool>> whereLambda)
        {
            return dmc.Set<T>().Where(whereLambda);
        }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <param name="whereLambda"></param>
        /// <param name="whereOrderBy"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> whereOrderBy, bool isAsc)
        {
            total = dmc.Set<T>().Where(whereLambda).Count();

            if (isAsc)
            {
                var temp = dmc.Set<T>().Where(whereLambda)
                          .OrderBy<T, S>(whereOrderBy)
                          .Skip(pageSize * (pageIndex - 1))
                          .Take(pageSize).AsQueryable();
                return temp;
            }
            else
            {
                var temp = dmc.Set<T>().Where(whereLambda)
                            .OrderByDescending<T, S>(whereOrderBy)
                            .Skip(pageSize * (pageIndex - 1))
                            .Take(pageSize).AsQueryable();
                return temp;
            }


        }

    }
}
