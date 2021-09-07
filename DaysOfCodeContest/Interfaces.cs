using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            if (n > 1)
            {
                int res = 1 + n;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        res += i;
                    }
                }
                return res;
            }
            else
            {
                return 1;
            }
        }
    }
}
