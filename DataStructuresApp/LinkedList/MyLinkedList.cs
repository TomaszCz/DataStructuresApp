using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.LinkedList
{
    public class Node
    {
        public Node? next;
        public Node? prev;
        public int data;
        public Node(int data) => this.data = data;
    }

    internal class MyLinkedList
    {
        Node? head;
        Node? tail;

        public void Append(int data)
        {
            if (head == null)
            {
                head = new(data);
                tail = head;
                return;
            }

            Node newTail = new(data);
            newTail.prev = tail;
            tail.next = newTail;
            tail = newTail;
        }

        public void Prepend(int data)
        {
            if (head == null)
            {
                head = new(data);
                tail = head;
                return;
            }

            Node newHead = new(data);
            newHead.next = head;
            head.prev = newHead;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                head.prev = null;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    current.next.prev = current;
                    return;
                }

                current = current.next;

            }
        }

        public void Display()
        {
            if (head == null) return;
            Node current = head;
            while (current.next != null)
            {
                Console.Write(current.data.ToString() + ' ');
                current = current.next;
            }
            Console.Write(current.data.ToString() + ' ');

            Console.Write('\n');
        }

        public void DisplayReverse()
        {
            if (tail == null) return;
            Node current = tail;
            while (current.prev != null)
            {
                Console.Write(current.data.ToString() + ' ');
                current = current.prev;
            }
            Console.Write(current.data.ToString() + ' ');
            Console.Write('\n');
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool Find(int value)
        {
            if (head == null) return false;
            Node current = head;
            while (current.next != null)
            {
                if (value == current.next.data)
                {
                    return true;
                }
                current = current.next;
            }

            return false;
        }
    }
}
