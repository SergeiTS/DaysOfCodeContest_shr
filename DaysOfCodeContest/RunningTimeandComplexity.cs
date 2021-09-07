using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class RunningTimeandComplexity
    {
        public static string IsPrime(int n)
        {
            if (n == 1)
            {
                return "Not prime";
            }
            for (int x = 2; Math.Sqrt(n) >= x; x++)
            {
                if (n % x == 0)
                {
                    return "Not prime";
                }
            }
            return "Prime";
        }
    }
}
