using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractionAndPolymorphismExample
{
    public class PremiumCustomer : Customer, IDiscount
    {
        public PremiumCustomer()
        {
            this.Type = CustomerType.PremiumCustomer;
        }

        public int CalculateDiscount()
        {
            
            return (new Random()).Next(50, 100);
        }

        public override int CalculateRewards()
        {
            Console.WriteLine("PremiumCustomer Class Implementation");
            return (new Random()).Next(5000, 15000);
        }
    }
}
