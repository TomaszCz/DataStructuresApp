using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.BinarySearchTree
{
    class MyBinarySearchTreeNode
    {
        MyBinarySearchTreeNode left, right;
        int data;
        public MyBinarySearchTreeNode(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new MyBinarySearchTreeNode(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new MyBinarySearchTreeNode(value);

                }
                else
                {
                    right.Insert(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.Contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
        }

        public void PrintInOrder()
        {
            if (left != null)
            {
                left.PrintInOrder();
            }
            Console.Write(data.ToString() + ' ');
            if (right != null)
            {
                right.PrintInOrder();
            }
        }

        public void PrintPreOrder()
        {
            Console.Write(data.ToString() + ' ');
            if (left != null)
            {
                left.PrintPreOrder();
            }
            if (right != null)
            {
                right.PrintPreOrder();
            }
        }

        public void PrintPostOrder()
        {
            if (left != null)
            {
                left.PrintPostOrder();
            }
            if (right != null)
            {
                right.PrintPostOrder();
            }
            Console.Write(data.ToString() + ' ');
        }

    }
}