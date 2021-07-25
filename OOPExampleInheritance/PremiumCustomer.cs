using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampleInheritance
{
    public class PremiumCustomer: Customer
    {
        public PremiumCustomer(int id):base(id)
        {
            Console.WriteLine("PremiumCustomer Class COnstructor");
        }
        public override int CalculateRewards()
        {
            Console.WriteLine("PremiumCustomer Class Calculate Rewards implementation");
            return (new Random()).Next(5000, 15000);
        }
    }
}
