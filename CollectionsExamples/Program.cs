using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExamples
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Store 5 numbers
            int[] nums = new int[] { 2, 4, 1, 5, 6 };

            
            //If you want to 2 more numbers
            //You have resize or recreate array.

            nums = new int[7];
            nums[0] = 2;
            nums[1] = 4;
            nums[2] = 1;
            nums[3] = 5;
            nums[4] = 6;
            nums[5] = 7;
            nums[6] = 8;

            // BaseClass obj = new ChildClass();
            // Object obj = 2
            
            ArrayList myList = new ArrayList();
            myList.Add(2);
            myList.Add(4);

            int j = 10;
            object o = j; // Converting value type to reference type (Boxing)



            string city = "Charlotte";
            Customer customer = new Customer() { Id = 1, Name = "Nitin" };

            myList.Add(city);
            myList.Add(customer);

            for (int i = 0; i < myList.Count; i++)//Length
            {                
                Console.WriteLine(myList[i]);// Similar to Array
            }

            Customer cust = (Customer)myList[3];

            
                       
            
            

            //Generics, Typed Parameter <T>

            List<int> myNumbers = new List<int>();
            myNumbers.Add(12);
            myNumbers.Add(16);
            myNumbers.Add(25);

            foreach (int item in myNumbers)
            {
                Console.WriteLine(item);
            }
            myNumbers.Remove(12);
            Console.WriteLine(myNumbers.Contains(12));

            List<Customer> customers = new List<Customer>();
            customers.Add(cust);


            var age = "Nitin";
            int _age = 25;


            var department = new { Name = "Inventory" };
            Console.WriteLine(department.Name);
            //department.Name = "aa";
        }
    }
}

//// Database
//// CustomerDAC, ProductDAC - CRUD

//class DAC<T>
//{
//    void Add(T val)
//    {
        
//    }
//}

//DAC<Customer> customerDAC = new DAC<Customer>();
//customerDAC.Add()