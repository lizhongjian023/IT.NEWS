using IT.NEWS.IBll;
using IT.NEWS.IDal;
using IT.NEWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Bll
{
    public partial class CompanyService : BaseService<Company>, ICompanyService
    {
        //public CompanyService(IDbSession DbSession) : base(DbSession)
        //{
        //    this.CurrentDal = DbSession.CompanyDal;
        //}
    }
}
