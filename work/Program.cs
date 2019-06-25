using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace work
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            //program.wirtetofile("what");
            Console.WriteLine("hello world");
            Console.WriteLine(args[0]);
            // Console.WriteLine(args[1]);
            string URL = "http://localhost:50924/api/values";// WebApi url
            string Param = args[0];
            var a = Newtonsoft.Json.JsonConvert.SerializeObject(Param);
            SendHttpRequest(URL, a);
        }
        public void wirtetofile(string needwritetofile)
        {
            string filePath = "C:/Users/yanliang.song/Desktop/2323.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fs = new FileStream(filePath, FileMode.Create);//获得字节数组          
            byte[] data = System.Text.Encoding.Default.GetBytes(needwritetofile);//开始写入
            fs.Write(data, 0, data.Length);//清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
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
