using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.BinarySearchTree
{
    internal class MyBinarySearchTreeUsage
    {
        public static void Run()
        {
            MyBinarySearchTreeNode bst = new MyBinarySearchTreeNode(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(8);

            // Tree:
            //     10
            //     / \
            //    5   15
            //     \
            //      8

            bst.PrintInOrder();
            // 5 8 10 15

            Console.WriteLine('\n');
            bst.PrintPostOrder();
            // 8 5 15 10

            Console.WriteLine('\n');
            bst.PrintPreOrder();
            // 10 5 8 15
        }
    }
}
