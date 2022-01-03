using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.LinkedList
{
    internal class MyLinkedListUsage
    {
        public static void Run()
        {
            MyLinkedList LinkedList = new();
            LinkedList.Append(5);
            LinkedList.Append(6);
            LinkedList.Append(7);
            LinkedList.Append(8);
            LinkedList.Append(9);
            LinkedList.Append(10);
            LinkedList.Prepend(4);
            LinkedList.Prepend(3);
            LinkedList.Prepend(2);
            LinkedList.Prepend(1);

            LinkedList.Display();
            // 1 2 3 4 5 6 7 8 9 10
            LinkedList.DisplayReverse();
            // 10 9 8 7 6 5 4 3 2 1

            LinkedList.Find(7); // true
            LinkedList.DeleteWithValue(7);
            LinkedList.DeleteWithValue(1);
            LinkedList.Find(7); // false

            LinkedList.Display();
            // 2 3 4 5 6 8 9 10
            LinkedList.DisplayReverse();
            // 10 9 8 6 5 4 3 2

        }
    }
}
