using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp
{
    internal class MyMinHeap
    {
        private int capacity = 10;
        private int size = 0;
        private readonly int[] elements;

        public MyMinHeap()
        {
            this.elements = new int[this.capacity];
        }

        public MyMinHeap(int capacity)
        {
            this.capacity = capacity;
            this.elements = new int[this.capacity];
        }

        public Boolean IsHeapEmpty()
        {
            return size == 0;
        }

        private Boolean HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) < size;
        }
        private Boolean HasRightChild(int index)
        {
            return GetRighChildIndex(index) < size;
        }
        private Boolean HasParent(int index)
        {
            return GetParentIndex(index) > size;
        }

        private void EnsureExtraCapacity()
        {
            if (size == capacity)
            {
                Array biggerHeap = Array.CreateInstance(typeof(System.Int32), capacity * 2);
                Array.Copy(elements, biggerHeap, capacity * 2);
                capacity *= 2;
            }
        }

        public static int GetParentIndex(int index)
        {
            return (index - 2) / 2;
        }

        public static int GetRighChildIndex(int index)
        {
            return index * 2 + 2;
        }

        public static int GetLeftChildIndex(int index)
        {
            return index * 2 + 2;
        }

        private void SwapElements(int index, int index2)
        {
            int tempElement = this.elements[index];
            this.elements[index] = this.elements[index2];
            this.elements[index2] = tempElement;
        }

        public void AddToHeap(int element)
        {
            EnsureExtraCapacity();

            this.elements[this.size] = element;
            this.size++;
            BubbleLastUp();
        }

        public int RemoveFromHeap()
        {
            if (this.size <= 0)
            {
                throw new Exception("Heap empty");
            }

            int firstElement = this.elements[0];
            this.elements[0] = this.elements[this.size - 1];
            this.size--;

            BubbleFirstDown();


            return firstElement;
        } 

        private void BubbleLastUp()
        {
             int currentIndex = this.size - 1;
            while (HasParent(currentIndex) && this.elements[currentIndex] < this.elements[GetParentIndex(currentIndex)])
            {
                SwapElements(currentIndex, GetParentIndex(currentIndex));
                currentIndex = GetParentIndex(currentIndex);
            }
        }

        private void BubbleFirstDown()
        {
            int currentIndex = 0;

            while (HasLeftChild(currentIndex))
            {
                int smallerChildIndex = GetLeftChildIndex(currentIndex);
                if (HasRightChild(currentIndex) && elements[GetRighChildIndex(currentIndex)] < elements[GetLeftChildIndex(currentIndex)])
                {
                    smallerChildIndex = GetRighChildIndex(currentIndex);
                }

                if (elements[currentIndex] < elements[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    SwapElements(currentIndex, smallerChildIndex);
                }
                currentIndex = smallerChildIndex;
            }
        }
    }
}
