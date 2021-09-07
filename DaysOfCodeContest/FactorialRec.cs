using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class FactorialRec
    {
        public static int Factorial(int n)
        {
            if ( n < 0 )
            {
                return -1;
            }
            else if ( n == 0 )
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
