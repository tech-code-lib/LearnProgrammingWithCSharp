using System;

namespace PassingParamsByVal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 15;

            SwapTwoNumbers(i, j);
            
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

    }
}
