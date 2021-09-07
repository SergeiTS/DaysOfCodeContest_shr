using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class BitwiseAND
    {
        public static int BiggestBitwise(int N, int K)
        {
            int t = 0;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    int b = i & j;
                    if (b < K && b > t)
                    {
                        t = b;
                    }
                }
            }
            return t;
        }
    }
}
