using System;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            Console.Write("Enter Number1 :- ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 :- ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var sum = new Sum().Add(num1, num2);
            Console.WriteLine("Sum is:" + sum);
            
            //Square 
            var squre = new Square().squr(num1);
            Console.WriteLine("Num1 Squre is:"+ squre);

            //Factorial
            var fact = new Factorial().fact(num1);
            Console.WriteLine("Factorial Number : " + fact);
        }
    }
}

