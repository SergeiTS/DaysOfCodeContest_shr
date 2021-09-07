using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Conditionals
    {
        public static void Condition(int n)
        {
            if ( n % 2 != 0 )
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if ( n >=2 && n<=5 )
                {
                    Console.WriteLine("Not Weird");
                }
                else if ( n >= 6 && n <= 20 )
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
