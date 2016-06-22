using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace HelloMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
            
            var host = new WebHostBuilder().UseUrls($"http://*:{port}")
                                           .UseKestrel()
                                           .UseContentRoot(Directory.GetCurrentDirectory())
                                           .UseStartup<Startup>()
                                           .Build();

            host.Run();
        }
    }
}
