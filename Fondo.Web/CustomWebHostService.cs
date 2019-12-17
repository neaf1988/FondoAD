using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using System;

namespace Fondo.Web
{
    /// <summary>
    /// Class that allows to handle the events of the windows service
    /// </summary>
    internal class CustomWebHostService : WebHostService
    {
        

        /// <summary>
        /// Initializes a new instance of <see cref="CustomWebHostService"/>
        /// </summary>
        /// <param name="host"></param>
        public CustomWebHostService(IWebHost host) : base(host)
        {
            
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }


        /// <summary>
        /// This will fire for unhandled exceptions in the given domain no matter what thread they occur on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //AGMCException exception = e.ExceptionObject as AGMCException;

            //if (exception == null)
            //{
            //    string message = _localizer.GetMessage("AGMCError_WindowsServiceUnhandledException");
            //    exception = new AGMCException(message, e.ExceptionObject as Exception);
            //}

            //if (_logger != null && exception != null)
            //{
            //    //Allows to write the error in the application log
            //    _logger.WriteError(exception.Message, exception);
            //}
        }

        

        protected override void OnStarting(string[] args)
        {
            //Debugger.Launch();
            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
           
            base.OnStarting(args);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopping()
        {
          
            base.OnStopping();
        }

        protected override void OnStopped()
        {
            base.OnStopped();
        }
    }
}
