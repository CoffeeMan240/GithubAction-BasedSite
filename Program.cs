using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace CANYUOUPOSTONGITHUBNOW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HttpListener server = new HttpListener();
            server.Prefixes.Add("http://0.0.0.0:6969/");
            for(; ; )
            {
                server.Start();
                Console.WriteLine("Abuseing Github for RecNoot might happen lol");
                var ctx = server.GetContext();
                string rawurl = ctx.Request.RawUrl;
                string r = "HELLO! HOW ARE YOU?";
                Console.WriteLine("Requested! " + rawurl);
                byte[] send = Encoding.ASCII.GetBytes(r);
                ctx.Response.ContentLength64 = send.Length;
                Stream output = ctx.Response.OutputStream;
                output.Write(send, 0, send.Length);
                Thread.Sleep(100);
                server.Close();

            }
        }
    }
}
