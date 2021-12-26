using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Queue
{
    internal class MyQueue
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

        private Node? head;
        private Node? tail;

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue empty");
            }
            return head.data;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }


        }

        public int Remove()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue empty");
            }

            int data = head.data;
            head = head.next;

            if (head == null)
            {
                tail = null;
            }
            return data;
        }

    }
}
