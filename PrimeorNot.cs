using System;

namespace PrimeOrNotPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine(number + " is prime");
            }
            else
            {
                    Console.WriteLine(number + " is not prime");
            }
        }
    }
}
