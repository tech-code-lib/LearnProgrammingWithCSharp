using System;

namespace ProgrammingBasics
{
    /// <summary>
    /// Structure
    /// </summary>
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Comparison and Logical Operators

                //ToDo: Comparison Operators

                //  == equals to
                //  != not equals to
                //  > greater than
                //  <
                //  >=
                //  <=

                //ToDo: Logical Operators
                //  && --> AND
                //  || --> OR
                //  !

            #endregion

            //ToDo: Conditional Statement If-Else code block
            #region Conditional Statements (If-Else)

                UserEntry:
                Console.WriteLine("Are you a prime member?Enter Y or N");
                //char response = ((char)Console.ReadKey().Key);
                char response = Convert.ToChar(Console.ReadLine());
                bool primeMember = false;
                if (response == 'Y')
                {
                    primeMember = true;
                }
                else if (response == 'N')
                {
                    primeMember = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    goto UserEntry;
                }

                Console.WriteLine("Enter your age?");
                int age = int.Parse(Console.ReadLine());

                if (primeMember && age >= 25)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You are eligible for additional discount.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sorry, as you are not a prime member, you are not eligible for additional discount.");
                }

            #endregion

            //ToDo: Switch Statements
            #region Conditional Statements - Switch Statement

                Console.ForegroundColor = ConsoleColor.Yellow;

                int day = ((int)DateTime.Now.DayOfWeek);
                switch (day)
                {
                    case 7:
                        Console.WriteLine("Hurray!! it is a holiday");
                        break;

                    case 6:
                        Console.WriteLine("Hurray!! it is a holiday");
                        break;

                    case 5:
                        {
                            Console.WriteLine("Happy Friday");
                            Console.WriteLine("Join us on lunch");
                            break;
                        }

                    default:
                        Console.WriteLine("It is a working day.");
                        break;
                }

            #endregion


            //ToDo: Data Type : Array
            // Variable to hold multiple values of same data type

            int[] numbers = new int[3]; // numbers will store 3 integers at adjacent memory location.
            // 0, 1, 2 -- Indices
            numbers[0] = 5;
            numbers[1] = 15;
            numbers[2] = 25;
            //numbers[3] = 8; //  System.IndexOutOfRangeException: Index was outside the bounds of the array.

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Array Length: " + numbers.Length);

            //ToDo: Iteraration Statements - Loops(For Loop, While Loop, Do-While Loop)

            #region Iteration statements with Loops

                //For Loop
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }

                foreach (int item in numbers)
                {

                }

                int n = 0;
                while (n < 5)
                {
                    n++;
                }

                do
                {

                } while (n < 5);

            #endregion

            #region Strings in C#

            //ToDo: Strings in C#

            string name = "John Smith";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            string names = "John Mark Lisa";
            string[] namesArray = names.Split(" ");
            foreach (string nameToPrint in namesArray)
            {
                Console.WriteLine(nameToPrint);
            }

            //Substring

            string firstName = names.Substring(5, 4);
            Console.WriteLine(firstName);

            //replace
            string replacedString = names.Replace(" ", "*");
            Console.WriteLine(replacedString);

            string removedString = names.Remove(4);
            Console.WriteLine(removedString);

            Console.WriteLine(string.Join(", ", namesArray));

            Console.WriteLine("Escape Sequence");
            string testString = "\tMy name is\n \"Nitin Rastogi\"";
            Console.WriteLine(testString);

            #endregion

            #region Structures and Methods

                Print("Testing print message");
                int firstNo = 12;
                int secondNo = 13;
                int resultAdd = Add(firstNo, secondNo);
                Console.WriteLine($"Addition result of {firstNo} and {secondNo} is :{resultAdd}");
    
                Person person1;
                person1.FirstName = "Nitin";
                person1.LastName = "Rastogi";
                person1.Age = 38;
                person1.Email = "nitin.rastogi@live.in";
                PrintPerson(person1);

                Console.WriteLine("-------------");
            
                Person person2;
                person2.FirstName = "John";
                person2.LastName = "Smith";
                person2.Age = 24;
                person2.Email = "john@gmail.com";
                PrintPerson(person2);

            #endregion


            //Next
            // Read-only structures
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
            // 


        }

        static void PrintPerson(Person person)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Welcome {person.FirstName} {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Email: {person.Email}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Method to print a simple string message.
        /// </summary>
        /// <param name="msgToPrint"></param>
        static void Print(string msgToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Printing Message.....");
            Console.WriteLine($"{msgToPrint}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Method to Add two integers
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static int Add(int first, int second)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int result = first + second;
            Console.WriteLine($"Adding two numbers {first} and {second}");
            return result;
        }


    }
}
