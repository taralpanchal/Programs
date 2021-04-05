using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Digit : ");
            var digit = Convert.ToInt64(Console.ReadLine());

            var digitstr = digit.ToString();
            var leng = digitstr.Length;
            var i = leng - 1;
            var revesedigit = "";

            while (i >= 0)
            {
                revesedigit = revesedigit + digitstr[i];
                i--;
            }
            if(Convert.ToInt64(revesedigit) == digit)
            {
                Console.WriteLine(digit + " is Palindrom");
            }
            else
            {
                Console.WriteLine(digit + " is Not Palindrom");
            }
            
        }
    }
}
