using DataStructuresApp.Alghoritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Alghorithms
{
    internal class MyQuicksortUsage
    {
        public static void Run()
        {
            int[][] jaggedArray = new int[][]
                {
                new int[] { 3, 1, 8, 5, 6, 2, 4, 9, 7 },
                new int[] { 3, 4, 7, 5, 1, 2 },
                new int[] { 5, 4, 1, 3, 7 },
                new int[] { 6, 3, 1, 2, 5, 8, 7, 9, 15 }
                };

            foreach (int[] unsorted in jaggedArray)
            {
                MyQuicksort.Quicksort(unsorted);
            }

            foreach (int[] unsorted in jaggedArray)
            {
                foreach (int element in unsorted)
                {
                    Console.Write(element.ToString() + ' ');
                }
                Console.WriteLine('\n');
            }

            // 1 2 3 4 5 6 7 8 9

            // 1 2 3 4 5 7

            // 1 3 4 5 7

            // 1 2 3 5 6 7 8 9 15
        }
    }
}
