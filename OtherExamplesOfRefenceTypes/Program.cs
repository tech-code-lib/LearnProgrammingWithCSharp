using System;

namespace OtherExamplesOfRefenceTypes
{
    public struct Person
    {
        public string Name;
        public string Email;
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Customer customer = new Customer() { Name = "John", Email = "john@gmail.com" };

            Person person;
            person.Name = "Mike"; 
            person.Email = "mike@gmail.com";

            //ProcessCustomer(customer);
            //Console.WriteLine($"Printing Customer after processing data: Name: {customer.Name}, Email: {customer.Email }");

            //ProcessPerson(person);
            //Console.WriteLine($"Printing Person after processing data: Name: {person.Name}, Email: {person.Email }");
        }

        
        static void ProcessCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            customer.Name = "Nitin";
            customer.Email = "nitin@gmail.com";

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ProcessPerson(Person person)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            person.Name = "Nitin";
            person.Email = "nitin@gmail.com";
            
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
