using System;

namespace DelegatesExercise
{
    delegate int MathOp(int a, int b);
    delegate void Log(string message, DateTime timeStamp);
    class Program
    {
        static void Main(string[] args)
        {
            //MathOp mathOp = Add;
            //mathOp();

            int i = 10;
            i += 5;

            string msg = "Order has been shipped.";
            DateTime timeStamp = DateTime.Now;

            Log log = LogToFile;
            log += LogToDb;
            log(msg, timeStamp);

        }

        static int Add(int first, int second, int third)
        {
            return first + second + third;
        }

        static void LogToFile(string message, DateTime timeStamp)
        {
            Console.WriteLine($"Logging message: {message} to file at {timeStamp}");
        }

        static void LogToDb(string message, DateTime timeStamp)
        {
            Console.WriteLine($"Logging message: {message} to db at {timeStamp}");
        }
    }
}
