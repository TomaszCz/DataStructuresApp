using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Stack
{
    internal class MyStack
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node Top;

        public bool IsEmpty()
        {
            return Top == null;
        }

        public int Peek()
        {
            return Top.data;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            node.next = Top;
            Top = node;
        }

        public int Pop()
        {
            int data = Top.data;
            Top = Top.next;
            return data;
        }
    }
}
