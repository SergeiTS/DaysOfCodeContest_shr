using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class BinaryNumbers
    {
        public static void BinaryConvertion(int dNum)
        {
            int cnt = 0;
            int max = 0;
            List<int> bNum = new List<int>();
            //List<int> res = new List<int>();

            while ( dNum > 0 )
            {
                bNum.Add(dNum % 2);
                dNum /= 2;
            }
            for ( int i = 0; i < bNum.Count; i++ )
            //#1
            {
                //    if ( i == 0 && bNum[i] == 1 )
                //    {
                //        cnt++;
                //        continue;
                //    }
                //    else if ( i != 0 && cnt == 0 && bNum[i] == 1 )
                //    {
                //        cnt++;
                //        continue;
                //    }
                //    else if ( i != 0 && bNum[i] == 0 )
                //    {
                //        res.Add(cnt);
                //        cnt = 0;
                //        continue;
                //    }
                //    else if ( i != 0 && bNum[i] == 1 && bNum[i - 1] == 1 )
                //    {
                //        cnt++;
                //        continue;
                //    }
                //    else if ( i != 0 && bNum[i] == 1 && bNum[i - 1] == 0 )
                //    {
                //        cnt++;
                //        continue;
                //    }
                //    else
                //    {
                //        continue;
                //    }
                //}
                //res.Add(cnt);
                //Console.WriteLine($"{res.Max()}");
                if ( bNum[i] == 1 )
                {
                    cnt++;
                    if ( cnt > max )
                    {
                        max = cnt;
                    }
                }
                else
                {
                    cnt = 0;
                }
            }
            Console.WriteLine($"{max}");
        }
    }
}
