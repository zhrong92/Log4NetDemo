using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetDemo
{
    public class AppOpLog
    {
        public string UserPhone { get; set; }

        public string IP { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string ActionParam { get; set; }

        public string Url { get; set; }

        public string HttpHeader { get; set; }

        public string HttpMethod { get; set; }

        public string UserAgent { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string RunTime { get; set; }
    }
}
