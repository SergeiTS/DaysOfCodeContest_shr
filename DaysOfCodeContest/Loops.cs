using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Loops
    {
        public static void PrintNumbers(int n)
        {
            for ( int i = 1; i <= 10; i++ )
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
