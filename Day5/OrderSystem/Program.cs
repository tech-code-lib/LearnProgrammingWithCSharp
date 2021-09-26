using OrderSystemBusinessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();

            //service.LogMethod = FileLogger.LogToFile;
            //service.LogMethod = null;


            service.LogEvent += Service_LogEvent;
            //service.LogEvent = null;

            service.CustomEvent += Service_CustomEvent;
            
            service.PlaceOrder();
            
        }

        private static void Service_CustomEvent(object sender, OrderEventArgs e)
        {
        
            Console.WriteLine("Order is generated with Id: " + e.OrderId);

        }


        //private static void Service_CustomEvent(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Event Triggered");
        //}

        private static void Service_LogEvent(string msg, DateTime timeStamp)
        {
            FileLogger.LogToFile(msg, timeStamp);
            DBLogger.LogToDb(msg, timeStamp);

        }
    }
}
