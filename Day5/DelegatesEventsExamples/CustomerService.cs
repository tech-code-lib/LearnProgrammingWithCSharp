using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsExamples
{
    public class CustomerService
    {
        private Logger logger;
        public CustomerService()
        {
            logger = new Logger();            
        }

        public void LogIn(Customer customer)
        {
            customer.LoggedIn = true;
            string msg = $"Customer {customer.FirstName} logs in.";            
            logger.LogMethod(msg);
        }
    }
}
