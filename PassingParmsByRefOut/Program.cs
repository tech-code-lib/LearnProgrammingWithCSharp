using System;

namespace PassingParmsByRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int percent;
            GetDiscountPercentage(out percent, 1);
            Console.WriteLine($"Current discount value in% is {percent}");
        }


        static void GetDiscountPercentage(out int percentage, int type)
        {
            percentage = (type == 0) ? 5 : 10;
        }
    }
}
