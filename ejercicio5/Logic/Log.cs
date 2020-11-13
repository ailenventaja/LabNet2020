using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;

namespace Logic
{
    public class Log2
    {
        public static void save(object obj, Exception e)
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string hour = DateTime.Now.ToString("HH:mm:ss");
            string path = HttpContext.Current.Request.MapPath("~/log/" + date + ".txt");
            
            StreamWriter sw = new StreamWriter(path, true);
            StackTrace stackTrace = new StackTrace();
            sw.WriteLine(obj.GetType().FullName + " " + hour);
            sw.WriteLine(stackTrace.GetFrame(1).GetMethod().Name + " - " + e.Message);
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }
    }
}
