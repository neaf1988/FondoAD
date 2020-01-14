using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Common.Shared
{
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
            _logger = LogManager.GetLogger(typeof(LoggerService));

        }
        private ILog _logger;

        public void Debug(string message)
        {
            if (_logger.IsDebugEnabled)
            {
                _logger.Debug(message);
            }
        }

        public void Error(string message, Exception ex = null)
        {
            if (_logger.IsErrorEnabled && ex == null)
            {
                _logger.Error(message);
            }else if (_logger.IsErrorEnabled && ex != null)
            {
                _logger.Error(message, ex);
            }
        }

        public void Fatal(string message, Exception ex = null)
        {
            if (_logger.IsFatalEnabled)
            {
                _logger.Fatal(message);
            }
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
