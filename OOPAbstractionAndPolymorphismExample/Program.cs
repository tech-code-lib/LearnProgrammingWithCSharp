using System;

namespace OOPAbstractionAndPolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction");
            //Customer customer = new Customer();

            Console.ForegroundColor = ConsoleColor.Green;
            WebCustomer webCustomer = new WebCustomer();
            webCustomer.Id = 105;
            webCustomer.Name = "Nitin";
            webCustomer.Email = "nitin.rastogi@live.in";
            int rewards = webCustomer.CalculateRewards();
            
            Console.WriteLine($"\nCustomer {webCustomer.Name}, Type:{webCustomer.Type}, Email:{webCustomer.Email}, Rewards: {rewards}\n");


            Console.ForegroundColor = ConsoleColor.Yellow;
            PremiumCustomer primeCustomer = new PremiumCustomer();
            primeCustomer.Id = 105;
            primeCustomer.Name = "Nitin";
            primeCustomer.Email = "nitin.rastogi@live.in";
            int pRewards = primeCustomer.CalculateRewards();
            
            Console.WriteLine($"\nCustomer {primeCustomer.Name}, Type:{primeCustomer.Type}, Email:{primeCustomer.Email}, Rewards: {pRewards}\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Are you a prime member?");
            var response = Console.ReadKey().KeyChar.ToString().ToUpper();
            Customer customer = (response == "Y") ? new PremiumCustomer() : new WebCustomer();
            Console.WriteLine();
            
            customer.Id = 105;
            customer.Name = "Shanthi";
            customer.Email = "Shanthi@gmail.com";
            int CustRewards = customer.CalculateRewards();

            Console.WriteLine($"\nCustomer {customer.Name}, Type:{customer.Type}, Email:{customer.Email}, Rewards: {CustRewards}\n");

            IDiscount obj = (response == "Y") ? new PremiumCustomer() : new WebCustomer();
            Console.WriteLine(obj.CalculateDiscount());
            

        }
    }
}
