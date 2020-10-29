using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch07
{
    class E34_SortString
    {
        public static void Execute()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Sorted string: {0}", Sort(str));
        }

        static string Sort(string s)
        {
            char[] c = s.ToCharArray();
            QuickSort(c);
            return string.Join("", c);
        }

        static int Partition(char[] arr, int low, int high)
        {
            int pivot = arr[low];
            int biggerCounter = 0;
            char temp;
            int j;

            for (int i = high; i > 0; i--)
            {
                if (arr[i] > pivot)
                {
                    j = high - biggerCounter;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    biggerCounter++;
                }
            }

            j = high - biggerCounter;
            temp = arr[low];
            arr[low] = arr[j];
            arr[j] = temp;

            return j;
        }

        static void QuickSort(char[] arr)
        {
            QuickSortRecursive(arr, 0, arr.Length - 1);
        }

        static void QuickSortRecursive(char[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSortRecursive(arr, low, pi - 1);
                QuickSortRecursive(arr, pi + 1, high);
            }
        }
    }
}
