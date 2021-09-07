using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class NestedLogic
    {

        public static void FineCalculation(int aD, int eD, int aM, int eM, int aY, int eY)
        {
            if (eY > aY)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (eY >= aY)
                {
                    if (eM >= aM)
                    {
                        if (eD >= aD)
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine(15 * (aD - eD));
                        }
                    }
                    else
                    {
                        Console.WriteLine(500 * (aM - eM));
                    }
                }
                else
                {
                    Console.WriteLine("10000");
                }
            }

        }

    }
}
