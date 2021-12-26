using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Queue
{
    internal class MyQueueUsage
    {
        public static void Run()
        {
            MyQueue queue = new();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);

            while (!queue.IsEmpty())
            {
                Console.Write(queue.Remove().ToString() + ' ');
            }
            // 1 2 3 4 5
        }
    }
}
