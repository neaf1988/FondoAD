using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Common
{
    public class FondoSettings
    {
        public static FondoSettings Current;

        public FondoSettings()
        {
            Current = this;
        }

        public string ConfigurationKey { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }
    }
}
