using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Log4NetDemo
{
    public class LogHelper
    {
        public static string LoggerName = "DbLogger";

        private static ILog log = LogManager.GetLogger(LoggerName);
        
        /// <summary>
        /// 记录一般日志
        /// </summary>
        public static void LogInfo(AppOpLog opLog)
        {
            if (log.IsInfoEnabled)
            {
                log.Info(opLog);
            }
        }

        /// <summary>
        /// 记录错误
        /// </summary>
        public static void LogError(AppOpLog opLog, Exception ex)
        {
            if (log.IsErrorEnabled)
            {
                log.Error(opLog, ex);
            }
        }

        /// <summary>
        /// 记录严重错误
        /// </summary>
        public static void LogFatal(AppOpLog opLog, Exception ex)
        {
            if (log.IsFatalEnabled)
            {
                log.Fatal(opLog, ex);
            }
        }

        /// <summary>
        /// 记录警告
        /// </summary>
        public static void LogWarn(AppOpLog opLog)
        {
            if (log.IsWarnEnabled)
            {
                log.Warn(opLog);
            }
        }
    }
}
