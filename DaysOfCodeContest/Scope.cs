using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Scope
    {
    }
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            this.elements = a;
        }
        public int computeDifference()
        {
            // #1
            //for (int i = 0; i < elements.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < elements.Length; j++)
            //    {
            //        int diff = Math.Abs(elements[i] - elements[j]);
            //        if (diff > maximumDifference)
            //        {
            //            maximumDifference = diff;
            //        }
            //    }
            //}
            //return maximumDifference;
            // #2
            return maximumDifference = elements.Max() - elements.Min();
        }
    }
}
