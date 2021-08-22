using System;
using System.Collections;

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

            ArrayList myList = new ArrayList();
            myList.Add(2);
            myList.Add(4);

            int j = 10;
            object o = j; // Converting value type to reference type (Boxing)



            string city = "Charlotte";
            Customer customer = new Customer() { Id = 1, Name = "Nitin" };

            myList.Add(city);
            myList.Add(customer);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            var department = new { Name = "Inventory" };
            //department.Name = "aa";
                       
            
            Console.WriteLine(department.Name);

        }
    }
}
