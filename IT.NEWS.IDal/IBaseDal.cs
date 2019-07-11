using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.IDal
{
    public interface IBaseDal<T> where T : class, new()
    {
        int Add(T t);

        int Update(T t);

        int Detele(T t);


        //T GetModel(Expression<Func<T,T>> whereLambda);

        IQueryable<T> GetList(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> whereOrderBy, bool isAsc);
    }
}
