using System;

namespace OOPExampleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance example");

            WebCustomer webCustomer = new WebCustomer(201) 
            { 
                FName = "John", LName = "Smith", Email = "john.smioth@gmail.com", WebUserId = 201 
            };
            Console.WriteLine($"WebCustomer rewards: {webCustomer.CalculateRewards()}");

            PremiumCustomer premiumCustomer = new PremiumCustomer(2011)
            {
                
                FName = "John",
                LName = "Smith",
                Email = "john.smioth@gmail.com",
                
            };
            Console.WriteLine($"PremiumCustomer rewards: {premiumCustomer.CalculateRewards()}");

        }
    }
}
