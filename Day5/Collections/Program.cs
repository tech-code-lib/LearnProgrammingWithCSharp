using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        /// <summary>
        /// HashTable, Dictionary
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Customer customer1 = new Customer { CustomerId = 1, FirstName = "Nitin", LastName = "Rastogi", Email = "nitin@gmail.com" };
            Customer customer2 = new Customer { CustomerId = 2, FirstName = "John", LastName = "Smith", Email = "john@gmail.com" };
            Customer customer3 = new Customer { CustomerId = 3, FirstName = "Nick", LastName = "White", Email = "nic@gmail.com" };

            Hashtable hashtable = new Hashtable();

            AddCustomerToList(hashtable, customer1.CustomerId, customer1);

            AddCustomerToList(hashtable, customer2.CustomerId, customer2);
            
            AddCustomerToList(hashtable, customer3.CustomerId, customer3);

            var cust = hashtable[5] as Customer;

            //Console.WriteLine(cust.Email);


            Dictionary<int, Customer> map = new Dictionary<int, Customer>();

            AddCustomerToDictionary(map, customer1.CustomerId, customer1);
            Customer cust2 = map[customer1.CustomerId];
            Console.WriteLine(cust2.Email);

            //First In First Out
            Queue<ToDo> toDos = new Queue<ToDo>();
            toDos.Enqueue(CreateToDo(1, "Day5 Training"));
            toDos.Enqueue(CreateToDo(2, "Day5 Assignment"));
            toDos.Enqueue(CreateToDo(3, "Book Tickets"));


            //PrintMyToDosList(toDos);

            
            // Last in First out
            Stack<ToDo> stackTodos = new Stack<ToDo>();
            stackTodos.Push(CreateToDo(4, "Stack Demo"));
            stackTodos.Push(CreateToDo(5, "Make Credit Card Payment"));

            PrintMyToDosStack(stackTodos);

            Tuple<string, ToDo> todoForNitin = new ("Nitin", CreateToDo(1, "Day5 Training"));
            Tuple<string, ToDo> todoForSteve = new("Steve", CreateToDo(1, "Day5 Training assignment"));

            Console.WriteLine(todoForNitin.Item2 + " " + todoForNitin.Item1);

        }

        static void PrintMyToDosStack(Stack<ToDo> stackTodos)
        {
            while (stackTodos.Count > 0)
            {
                Console.WriteLine(stackTodos.Pop());
            }
        }


        static void PrintMyToDosList(Queue<ToDo> todos)
        {
            while (todos.Count > 0)
            {
                Console.WriteLine(todos.Dequeue());
            }
        }

        static ToDo CreateToDo(int id, string todo)
        {
            return new ToDo() { Id = id, Title = todo };
        }
        
        static void AddCustomerToList(Hashtable hashtable, int key, Customer customer)
        {            
            if(!hashtable.ContainsKey(key))
                hashtable.Add(key, customer);
        }

        static void AddCustomerToDictionary(Dictionary<int, Customer> map, int key, Customer customer)
        {
            if (!map.ContainsKey(key))
                map.Add(key, customer);
        }

    }
}
