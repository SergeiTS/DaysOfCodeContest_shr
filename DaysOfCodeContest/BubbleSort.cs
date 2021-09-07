using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class BubbleSort
    {
        public static void Sort(int[] m)
        {
            int numSwaps = 0;
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m.Length - 1; j++)
                {
                    if (m[j] > m[j + 1])
                    {
                        int temp = m[j];
                        m[j] = m[j + 1];
                        m[j + 1] = temp;
                        numSwaps++;
                    }

                }
                if (numSwaps == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {m[0]}");
            Console.WriteLine($"Last Element: {m[m.Length - 1]}");
        }
    }
}
