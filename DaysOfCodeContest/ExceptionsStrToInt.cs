using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class ExceptionsStrToInt
    {
        public static void Parsetointexception(string str)
        {
            try
            {
                int res = int.Parse(str);
                Console.WriteLine(res);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
