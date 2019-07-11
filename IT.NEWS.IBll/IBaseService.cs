using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.IBll
{
    public interface IBaseService<T> where T: class,new ()
    {
        int Add(T t);

        int Update(T t);

        int Delete(T t);

        IQueryable< T> GetModels(Expression <Func<T,bool>> whereLambda);

        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> whereOrderBy, bool isAsc);
    }
}
