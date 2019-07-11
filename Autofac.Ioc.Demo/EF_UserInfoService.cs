using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autofac.Ioc.Demo
{
    public class EF_UserInfoService : IUserInfoService
    {
        public string Show()
        {
            return "This is EF_UserInfoService";
        }
    }
}