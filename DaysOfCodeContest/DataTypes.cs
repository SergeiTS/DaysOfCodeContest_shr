using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class DataTypes
    {
        public static void PrintDataTypes()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            string i2;
            i2 = Console.ReadLine();
            string d2;
            d2 = Console.ReadLine();
            string s2;
            s2 = Console.ReadLine();

            int iresult = int.Parse(i2) + i;
            double dresult = double.Parse(d2) + d;

            Console.WriteLine(iresult);
            Console.WriteLine($"{dresult:F10}");
            Console.WriteLine($"{s }{s2}");

            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
        }


    }
}
