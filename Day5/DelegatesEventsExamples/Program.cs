using System;

namespace DelegatesEventsExamples
{    
    class Program
    {
        delegate void ProcessStringData(string testString);
        delegate int Operation(int first, int second);

        static void Main(string[] args)
        {
            /*
            
            ProcessStringData myMethod;
            myMethod = Print;
            //myMethod = SaveToATextFile;
            myMethod("This is a sample string");

            */

            /*
            
            var myMethod = new ProcessStringData(Print);
            //myMethod("This is second sample string");
            myMethod.Invoke("This is second sample string");
            
            processData("Nitin Rastogi", myMethod);

            */

            /*
            var mathOperAdd = new Operation(Add);
            mathOperAdd += new Operation(Subtract);
            int result = mathOperAdd(12, 10);
            Console.WriteLine(result);
            */
            
            Customer customer = new Customer() { Id = 1, FirstName = "Nitin", LastName = "Rastogi" };
            Console.WriteLine(customer.LoggedIn);
            CustomerService customerService = new CustomerService();
            customerService.LogIn(customer);
            Console.WriteLine(customer.LoggedIn);
        }

        static int Add(int f, int s)
        {
            Console.WriteLine("Add");
            return f + s;
        }

        static int Subtract(int f, int s)
        {
            return f - s;
        }

        static void processData(string name, ProcessStringData methodToProcessString)
        {
            methodToProcessString("Mr. " + name);
        }

        static void Print(string str)
        {
            Console.WriteLine($"Priting string : \"{str}\"");
        }

        static void SaveToATextFile(string str)
        {
            Console.WriteLine($"String : \"{str}\" saved to a .txt file");
        }
    }
}
