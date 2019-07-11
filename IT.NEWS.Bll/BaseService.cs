using IT.NEWS.Dal;
using IT.NEWS.IBll;
using IT.NEWS.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
    public abstract class BaseService<T> where T : class, new()
    {
        //  获取一个公共的Dal
        public IBaseDal<T> CurrentDal { get; set; }

        public IDbSession DbSession { get; set; }
        public BaseService(IDbSession dbSesssion)   //基类的构造函数
        {
            DbSession = dbSesssion;
          //  SetCurrentDal();   //抽象方法
        }
        //  抽象方法，交给子类自己实现
    //    public abstract void SetCurrentDal();
        public int Add(T t)
        {
            return CurrentDal.Add(t);
        }

        public int Update(T t)
        {
            return CurrentDal.Update(t);
        }

        public int Delete(T t)
        {
            return CurrentDal.Detele(t);
        }

        public  IQueryable< T> GetModels(Expression <Func<T,bool>> whereLamba)
        {
            return CurrentDal.GetList(whereLamba);
        }

        public  IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> whereOrderBy, bool isAsc)
        {
            return CurrentDal.GetPageEntities(pageIndex, pageIndex, out total, whereLambda, whereOrderBy, isAsc);
        }

    }
}
