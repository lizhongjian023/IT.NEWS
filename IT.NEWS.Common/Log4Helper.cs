using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.NEWS.Common
{
    public static class Log4Helper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("LoginLogger");
        public static void WriteErr(string msg)
        {
            log.Error(msg + "Err级别，报错");
        }
        public static void WriteDebug(string msg)
        {
            log.Debug(msg + "Debug级别，报错");
        }
        public static void WriteInfo(string msg)
        {
            log.Info(msg + ",Info级别，报错");
        }
        public static void WriteWarn(string msg)
        {
            log.Warn(msg + "Warn级别，报错");
        }
        public static void WriteFatal(string msg)
        {
            log.Fatal(msg + "Fatal级别，报错");
        }


    }
}
