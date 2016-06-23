using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WorksOnMyMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string port = Environment.GetEnvironmentVariable("PORT") ?? "80";

            var host = new WebHostBuilder()
                .UseUrls($"http://*:{port}")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
