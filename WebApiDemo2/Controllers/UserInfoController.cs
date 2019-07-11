using IT.NEWS.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo2.Controllers
{

    /// <summary>
    /// webApi测试的通用类
    /// </summary>
    /// <returns></returns>
    public class UserInfoController : ApiController
    {

        //UserInfoService userInfoService = new UserInfoService();
        ///// <summary>
        /////   allusers  
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public string GetDemoInfo()
        //{
        //    return "这是一个Demo测试的方法";
        //}


        //[HttpGet]

        /////    单个用户
        //public string GetDemoInfoById( int id)
        //{
        //    return $"这是一个Demo测试的方法该对象的Id是{id}";
        //}
        ///// <summary>
        ///// 特性路由，相同路由
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[Route("UserInfo/QueryDemoInfo")]
        //[HttpGet]
        //public string QueryDemoInfo(int id)
        //{
        //    return $"Demo测试的方法:QueryDemoInfo该对象的Id是{id}"; ;
        //}

        ///// <summary>
        ///// 改
        ///// </summary>
        ///// <param name="userInfo"></param>
        ///// <returns></returns>
        //[HttpPost]
        //[Route("UserInfo/UpdateUserInfo")]
        //public string UpdateUserInfo([FromBody]UserInfo userInfo )
        //{
        //    //if (userInfoService.UpdateUserInfo(userInfo))
        //    //{
        //    //    return $"ok:{userInfo.UserName}";
        //    //}
        //    //else
        //    //{
        //    //    return $"no:{userInfo.UserName}";
        //    //}
        //    return "ok";
        //}
    }
}
