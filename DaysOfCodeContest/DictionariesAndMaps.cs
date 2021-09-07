using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class DictionariesAndMaps
    {
        public static void PrintCellNumber()
        {
            int cntNumbers = int.Parse(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            for ( int s = 0; s < cntNumbers; s++ )
            {
                string[] enteredValue = Console.ReadLine().Split(' ');
                string name = enteredValue[0];
                int number = int.Parse(enteredValue[1]);
                phoneBook.Add(name, number);
            }

            List<string> queries = new List<string>();
            for ( int q = 0; q < cntNumbers; q++ )
            {
                queries.Add(Console.ReadLine());
            }

            foreach ( string n in queries )
            {
                if ( phoneBook.ContainsKey(n) )
                {
                    phoneBook.TryGetValue(n, out int qValue);
                    Console.WriteLine($"{n}={qValue}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
