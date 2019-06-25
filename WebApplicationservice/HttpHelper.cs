using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationservice
{
    public static class HttpHelper
    {
        public static string SendHttpRequest(string requestURI, string json)
        {
            string requestData = json;
            string serviceUrl = requestURI;//string.Format("{0}/{1}", requestURI, requestMethod);
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
            myRequest.Method = "POST";
            byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(requestData);
            myRequest.ContentLength = buf.Length;
            myRequest.Timeout = 500000;
            myRequest.ContentType = "application/json";
            myRequest.MaximumAutomaticRedirections = 1;
            myRequest.AllowAutoRedirect = true;
            Stream newStream = myRequest.GetRequestStream();
            newStream.Write(buf, 0, buf.Length);
            newStream.Close();
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string ReqResult = reader.ReadToEnd();
            reader.Close();
            myResponse.Close();
            return ReqResult;
        }
    }
}
