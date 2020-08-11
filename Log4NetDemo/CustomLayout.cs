using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using log4net.Layout.Pattern;

namespace Log4NetDemo
{
    public class CustomLayout : log4net.Layout.PatternLayout
    {
        public CustomLayout()
        {
            this.AddConverter("UserPhone", typeof(UserPhonePatternConverter));
            this.AddConverter("IP", typeof(IPPatternConverter));
            this.AddConverter("ControllerName", typeof(ControllerNamePatternConverter));
            this.AddConverter("ActionName", typeof(ActionNamePatternConverter));
            this.AddConverter("ActionParam", typeof(ActionParamPatternConverter));
            this.AddConverter("Url", typeof(UrlPatternConverter));
            this.AddConverter("HttpHeader", typeof(HttpHeaderPatternConverter));
            this.AddConverter("HttpMethod", typeof(HttpMethodPatternConverter));
            this.AddConverter("UserAgent", typeof(UserAgentPatternConverter));
            this.AddConverter("StartTime", typeof(StartTimePatternConverter));
            this.AddConverter("EndTime", typeof(EndTimePatternConverter));
            this.AddConverter("RunTime", typeof(RunTimePatternConverter));
        }
    }

    internal sealed class UserPhonePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.UserPhone);
        }
    }

    internal sealed class IPPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.IP);
        }
    }

    internal sealed class ControllerNamePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.ControllerName);
        }
    }

    internal sealed class ActionNamePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.ActionName);
        }
    }

    internal sealed class ActionParamPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.ActionParam);
        }
    }

    internal sealed class UrlPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.Url);
        }
    }

    internal sealed class HttpHeaderPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.HttpHeader);
        }
    }

    internal sealed class HttpMethodPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.HttpMethod);
        }
    }

    internal sealed class UserAgentPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.UserAgent);
        }
    }

    internal sealed class StartTimePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.StartTime);
        }
    }

    internal sealed class EndTimePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.EndTime);
        }
    }

    internal sealed class RunTimePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            AppOpLog logMessage = loggingEvent.MessageObject as AppOpLog;

            if (logMessage != null)
                writer.Write(logMessage.RunTime);
        }
    }
}
