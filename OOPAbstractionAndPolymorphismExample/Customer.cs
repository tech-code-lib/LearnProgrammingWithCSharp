using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractionAndPolymorphismExample
{
    public enum CustomerType
    {
        WebCustomer,
        PremiumCustomer
    }

    public abstract class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public CustomerType Type { get; set; }

        public string GetOrderHistory()
        {
            return $"Last order Id: {(new Random()).Next(100, 1000)}, value: {(new Random()).Next(1000, 5000)}";
        }

        public abstract int CalculateRewards();
    }
}
