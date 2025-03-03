﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class D2Arrays
    {
        public static void MD2Arrays(int[][] arr)
        {
            int sum = -64;
            for ( int i = 0; i < 4; i++ )
            {
                for ( int j = 0; j < 4; j++ )
                {
                    int sumCur = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if ( sumCur > sum )
                    {
                        sum = sumCur;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
