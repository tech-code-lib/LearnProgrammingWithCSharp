using System;

namespace PassingParametersByValueByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 15;            
            
            SwapTwoNumbersByRef(ref i, ref j);
            Console.WriteLine($"First Number: {i}, Second Number: {j}");

            Console.WriteLine();
        }

        static void SwapTwoNumbers(int first, int second)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Before swap First Number: {first}, Second Number: {second}");
            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine($"After swap First Number: {first}, Second Number: {second}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void SwapTwoNumbersByRef(ref int first, ref int second)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Before swap First Number: {first}, Second Number: {second}");
            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine($"After swap First Number: {first}, Second Number: {second}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void SwapTwoNumbersByRef()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
