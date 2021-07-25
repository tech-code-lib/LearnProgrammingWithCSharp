using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampleInheritance
{
    public class WebCustomer: Customer
    {
        public WebCustomer(int id):base(id)
        {

        }
        public int WebUserId { get; set; }

        public override int CalculateRewards()
        {
            return base.CalculateRewards();
        }
    }
}
