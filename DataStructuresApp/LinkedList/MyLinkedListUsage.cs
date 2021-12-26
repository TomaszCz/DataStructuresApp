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
            LinkedList.Append(10);
            LinkedList.Append(9);
            LinkedList.Append(8);
            LinkedList.Append(7);
            LinkedList.Append(6);
            LinkedList.Append(5);
            LinkedList.Prepend(4);
            LinkedList.Prepend(3);
            LinkedList.Prepend(2);
            LinkedList.Prepend(1);
            LinkedList.DeleteWithValue(7);

            LinkedList.Display();
            // 1 2 3 4 10 9 8 6
        }
    }
}
