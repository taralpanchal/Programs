using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int currnum = 0;
            int prevnum = 1;

            Console.WriteLine("Enter Number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                int sum = currnum + prevnum;
                currnum = prevnum;
                prevnum = sum;
                Console.WriteLine("Fibonacci Series : " + prevnum);
            }
        }
    }
}
