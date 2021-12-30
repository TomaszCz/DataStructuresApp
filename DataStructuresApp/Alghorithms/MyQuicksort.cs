using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Alghoritms
{
    internal class MyQuicksort
    {
        public static void Quicksort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);
        }

        public static void Quicksort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            // why not (left + right)/2 ? If the array is very large (>2GB)  then the result of "left + right" may overflow and become negative. 
            // "left + (right-left)/2"  which is mathematically equivalent but immune to overflow as "right > left" is an invariant that always holds and if "right" is representable then, "left" is also representable the result will never overflow. as it will be less than "right"
            int pivot = array[left + (right - left) / 2];
            int index = Partition(array, left, right, pivot);

            Quicksort(array, left, index - 1);
            Quicksort(array, index, right);
        }

        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
