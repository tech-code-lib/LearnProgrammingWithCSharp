using System;

namespace OOPExampleEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndPrintCustomer(25, "John Smith");
            //CreateAndPrintCustomer(0, "Mark");
            Console.WriteLine();
            Console.ReadLine();

            Person person1 = new Person(102) { Name = "John" };
            person1.Walk();

            Person person2 = new Person(103) { Name = "John2" };
            person2.Walk();
        }

        static void CreateAndPrintCustomer(int age, string name)
        {
            try
            {
                Customer cust = new Customer("C123") { Age = age, Name = name };
                //cust.Age = age;
                //cust.Name = name;
                //cust.CustomerId = "aa";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Customer name: {cust.Name}, Age: {cust.Age}, {cust.CustomerId}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
