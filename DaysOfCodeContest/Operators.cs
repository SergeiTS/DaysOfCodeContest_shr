using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Operators
    {
        public static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip_value_toadd = (meal_cost * tip_percent) / 100;
            double tax_value_toadd = (meal_cost * tax_percent) / 100;
            double total_mealcost = Math.Round(meal_cost + tip_value_toadd + tax_value_toadd);
            Console.WriteLine(total_mealcost);

        }
    }
}
