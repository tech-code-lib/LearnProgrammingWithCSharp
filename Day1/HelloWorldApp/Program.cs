using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a Hello Message on output window.
            Console.WriteLine("Hello World");
            

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();//variable 'name' of data type string
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}
