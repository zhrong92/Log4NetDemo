using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure(
               new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\log4net.config")
           );

            AppOpLog opLog = new AppOpLog();
            opLog.IP = "192.124.0.0";
            opLog.ActionName = "action";
            opLog.ControllerName = "controller";
            opLog.ActionParam = "param";
            opLog.Url = "url";
            opLog.HttpHeader = "header";
            opLog.HttpMethod = "get";
            opLog.UserAgent = "useragent";
            opLog.StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            opLog.EndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            opLog.RunTime = (Convert.ToDateTime(opLog.EndTime) - Convert.ToDateTime(opLog.StartTime)).TotalSeconds.ToString();

            LogHelper.LogError(opLog,new Exception("error"));

            Console.ReadKey();
        }
    }
}
