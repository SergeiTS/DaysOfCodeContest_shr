using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Arrays
    {
        public static void PrintReverse(int n, int[] ar)
        {
            for ( int i = n-1; i >=0 ; i-- )
            {
                Console.Write($"{ar[i]} ");
            }
            //ar.Reverse();
        }
    }
}
