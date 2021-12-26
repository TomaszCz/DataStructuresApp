using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Heap
{
    internal class MyMiniHeapUsage
    {
        public static void Run()
        {
            MyMinHeap minHeap = new MyMinHeap(10);
            minHeap.AddToHeap(10);
            minHeap.AddToHeap(15);
            minHeap.AddToHeap(20);
            minHeap.AddToHeap(17);
            minHeap.AddToHeap(25);
            minHeap.AddToHeap(34);

            while (!minHeap.IsHeapEmpty())
            {
                Console.Write(minHeap.RemoveFromHeap().ToString() + ' ');
            }
            // 10 20 25 17 34 15
        }
    }
}
