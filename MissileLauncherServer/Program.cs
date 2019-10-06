using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace MissileLauncherServer
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($@"OWIN SelfHosting Service Started");
                Console.WriteLine($@"--------------------------------");
                Console.WriteLine($@"Location: {baseAddress}");
                Console.ReadLine();
            }
        }
    }
}