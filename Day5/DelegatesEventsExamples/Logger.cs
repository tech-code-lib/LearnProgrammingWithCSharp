using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsExamples
{
    public delegate void Log(string message);
    public class Logger
    {
        public Log LogMethod;

        public Logger()
        {
            LogMethod += FileLogger.LogToFile;
            LogMethod += DbLogger.LogToDB;
        }

    }
}
