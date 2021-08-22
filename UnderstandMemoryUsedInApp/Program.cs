using System;

namespace UnderstandMemoryUsedInApp
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class CustomerBusinessLogic
    {
        public void SaveCustomerToDb(Customer customer)
        {
            //In this method we write code to save Customer data in database.
            Console.WriteLine($"Customer {customer.Name} is saved in database");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Call a method to create a Customer in system.

            CreateCustomer();

            // Do other work.
            Console.WriteLine("Doing some other stuff.");
            Console.ReadLine();

        }

        static void CreateCustomer()
        {
            Console.WriteLine("Enter your name and Email.");
            string name = Console.ReadLine();
            string email = Console.ReadLine();

            Customer customer = new Customer() { Name = name, Email = email };

            CustomerBusinessLogic customerBusinessLogic = new CustomerBusinessLogic();
            customerBusinessLogic.SaveCustomerToDb(customer);
        }
    }
}
