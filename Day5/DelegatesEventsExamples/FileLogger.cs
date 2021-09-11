using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsExamples
{
    
    public class FileLogger
    {
        public static void LogToFile(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;  
            string msgToLog = $"Logging message to file: {message}, at {DateTime.Now.ToString()}";
            Console.WriteLine(msgToLog);
            Console.ResetColor();
        }


    }
}
