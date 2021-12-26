using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.LinkedList
{
    public class Node
    {
        public Node next;
        public int data;
        public Node(int data) => this.data = data;
    }

    internal class MyLinkedList
    {
        Node head;

        public void Append(int data)
        {
            if (head == null)
            {
                head = new(data);
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new(data);
        }

        public void Prepend(int data)
        {
            Node newHead = new(data);
            newHead.next = head;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }

                current = current.next;

            }
        }

        public void Display()
        {
            Node current = head;
            while(current.next != null)
            {
                Console.Write(current.data.ToString() + ' ');
                current = current.next;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
