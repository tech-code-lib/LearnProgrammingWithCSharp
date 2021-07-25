using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Breakpoint F9
            // Debug using F5
            // Step into a Method F11
            // Step over F10
            // Windows --> Quick Watch, Locals, Watch, Immediate Window(From menu Debug --> Windows)
            int result = Add(12, 3);
            Console.WriteLine($"Addition result: {result}");

            int[] numbers = new int[] { 2, 5, 3, 1 };
            PrintArray(numbers);

        }

        static int Add(int first, int second)
        {
            string message = $"Adding two numbers {first}, {second}";
            int result = first + second;
            return result;
        }

        //Error Handling
        static void PrintArray(int[] numbers)
        {

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                // Should throw exception as I am running loop for one extra iteration.
                // i < numbers.Length
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.WriteLine("Correct the code");
            }

            
        }
    }
}
