using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampleInheritance
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
            Console.WriteLine("Customer Class COnstructor");
        }

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }

        public virtual int CalculateRewards()
        {
            Console.WriteLine("Customer Class Calculate Rewards implementation");
            return (new Random()).Next(2000, 5000);

        }
    }
}
