using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Generics
    {
        public static void PrintArray<T>(T [] gArray )
        {
            foreach ( T gItem in gArray )
            {
                Console.WriteLine(gItem);
            }
        }
    }
}
