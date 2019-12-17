using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace Fondo.Web
{
    /// <summary>
    /// Class that contains utility extensions methods for the application
    /// </summary>
    public static class WebHostServiceExtensions
    {
        /// <summary>
        /// Allows to run the windows service as a custom service
        /// </summary>
        /// <param name="host"></param>
        public static void RunAsCustomService(this IWebHost host)
        {
            var webHostService = new CustomWebHostService(host);
            ServiceBase.Run(webHostService);
        }
    }
}
