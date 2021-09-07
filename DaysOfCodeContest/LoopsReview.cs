using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class LoopsReview
    {
        public static void PrintChars()
        {
            int cases = int.Parse(Console.ReadLine());
            string[] inputStrings = new string[cases];
            for ( int s = 0; s < cases; s++ )
            {
                inputStrings[s] = Console.ReadLine();
            }

            for ( int t = 0; t < inputStrings.Length; t++ )
            {
                string str = inputStrings[t];
                string evenC = "";
                string oddC = "";
                for ( int i = 0; i < str.Length; i++ )
                {
                    if ( i % 2 != 0 )
                    {
                        oddC += str[i];
                    }
                    else
                    {
                        evenC += str[i];
                    }
                }
                Console.WriteLine($"{evenC} {oddC}");
            }
        }
    }
}
