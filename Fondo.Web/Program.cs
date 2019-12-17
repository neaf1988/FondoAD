using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Fondo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isService = true;

            if (Debugger.IsAttached || args.Contains("--console"))
            {
                isService = false;
            }

            string pathToContentRoot = Directory.GetCurrentDirectory();

            if (isService)
            {
                string pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                pathToContentRoot = Path.GetDirectoryName(pathToExe);
            }
            var host = WebHost.CreateDefaultBuilder(args)
                        .UseContentRoot(pathToContentRoot)
                            .UseUrls("http://localhost:5000/")
                            .UseStartup<Startup>()
                            .Build();
            if (isService)
            {
                host.RunAsCustomService();
            }
            else
            {
                host.Run();
            }
        }
    }
}
