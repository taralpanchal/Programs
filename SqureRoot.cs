using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;

            Console.WriteLine("Enter Number : ");
            var number = Convert.ToInt32(Console.ReadLine()); 
             
            for(int i = 2; i < number; i++)
            {
                c = number / i;
                if( c * c == number )
                {
                    Console.WriteLine("Square Root is : " + c);
                }
            }

        }
    }
}
