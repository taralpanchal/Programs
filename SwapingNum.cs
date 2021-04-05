using System;

namespace SwapingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }
    }
}
