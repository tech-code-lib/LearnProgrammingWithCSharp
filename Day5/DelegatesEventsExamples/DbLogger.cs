using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsExamples
{
    public class DbLogger
    {
        public static void LogToDB(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string msgToLog = $"Logging message to DB: {message}, at {DateTime.Now.ToString()}";
            Console.WriteLine(msgToLog);
            Console.ResetColor();
        }
    }
}
