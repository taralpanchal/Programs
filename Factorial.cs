using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Factorial
    {
        public int fact(int a)
        {
            int fact = 1;
            for (int i = a; i > 1; --i)
            {
                fact = i * fact;
            }
            return fact;
        }
    }
}

