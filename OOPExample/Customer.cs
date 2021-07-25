using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampleEncapsulation
{
    public class Customer
    {
        private int _age;
        private string _name;
        private string _CustomerId;
        public Customer(string id)
        {
            _CustomerId = id;
        }

        public string CustomerId
        {
            get
            {
                return _CustomerId;
            }
        }
        public void UpdateSelfInfo()
        {
            
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Age
        {
            get { return _age; }
            set 
            {
                //Custom business logic before setting a value.
                if (value == 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                _age = value; 
            }
        }

    }
}
