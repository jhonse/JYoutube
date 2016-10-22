using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JYoutube.Lib
{
    class jDownLoad
    {
        private static CookieContainer cookie = new CookieContainer();
        private static string contentType = "application/x-www-form-urlencoded";
        private static string accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";
        private static string userWebAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
        private static string userWapAgent = "User-Agent:Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3_3 like Mac OS X; en-us)";

        public static string downPage(string url, Encoding encoding, bool isMobile=false)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                if (isMobile)
                {
                    request.UserAgent = userWapAgent;
                }else
                {
                    request.UserAgent = userWebAgent;
                }
                request.ContentType = contentType;
                request.CookieContainer = cookie;
                request.Accept = accept;
                request.Method = "get";

                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, encoding);
                String html = reader.ReadToEnd();
                response.Close();

                return html;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
