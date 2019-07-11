using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autofac.Ioc.Demo
{
    public class DapperUserInfoServie : IUserInfoService
    {

        public string Name { get; set; }
        public string Show()
        {
            return $"This is DapperUserInfoService,your name is {Name}";
        }
    }
}