using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Common.Shared
{
    public interface ILoggerService
    {
        void Error(string message, Exception ex=null);
        void Debug(string message);
        void Warn(string message);
        void Info(string message);
        void Fatal(string message, Exception ex = null);

    }
}
