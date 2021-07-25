using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampleEncapsulation
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public Person(int id)
        {
            PersonId = id;
        }

        public void Walk()
        {
            Console.WriteLine($"Person {this.Name} is walking");
        }

        public int Add(int f, int se)
        {
            return f + se;
        }
    }
}
