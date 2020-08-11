using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4MongoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure(
               new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\log4net.config")
           );

            AppOpLog opLog = new AppOpLog
            {
                UserPhone = "18888888888",
                IP = "192.124.0.0",
                ActionName = "action",
                ControllerName = "controller",
                ActionParam = "param",
                Url = "url",
                HttpHeader = "header",
                HttpMethod = "get",
                UserAgent = "useragent",
                StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                EndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
            };
            opLog.RunTime = (Convert.ToDateTime(opLog.EndTime) - Convert.ToDateTime(opLog.StartTime)).TotalSeconds.ToString();

            LogHelper.LogInfo(opLog);

            Console.ReadKey();
        }
    }
}
