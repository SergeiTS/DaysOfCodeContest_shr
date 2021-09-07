using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class MoreExceptions
    {
    }

    class ECalculator
    {
        public int power(int n, int p)
        {
            int res = 1;
            if (n >= 0 && p >= 0)
            {
                for (int i = 0; i < p; i++)
                {
                    res *= n;
                }
            }
            else
            {
                throw new Exception("n and p should be non-negative");
            }
            return res;
        }
    }
}
