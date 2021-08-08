using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractionAndPolymorphismExample
{
    public class WebCustomer : Customer, IDiscount
    {
        public WebCustomer()
        {
            this.Type = CustomerType.WebCustomer;
        }

        public int CalculateDiscount()
        {
            
            return (new Random()).Next(10, 50);
        }

        public override int CalculateRewards()
        {
            Console.WriteLine("WebCustomer Class Implementation");
            return (new Random()).Next(2000, 5000);
        }
    }
}
