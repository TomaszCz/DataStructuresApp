using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Stack
{
    internal class MyStackUsage
    {
        public static void Run()
        {
            MyStack stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop().ToString() + ' ');
            }
            // 5 4 3 2 1
        }
    }
}
