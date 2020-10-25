using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch07
{
    class E32_QuickSort
    {
        public static void Exectue()
        {
            Random random = new Random();
            int[] myArray = new int[20];

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(1, 100);

            Console.WriteLine("Original Array: ");
            PrintArray(myArray);
            Console.WriteLine("\n");

            int pivotIndex = Partition(myArray, 0, myArray.Length - 1);
            Console.WriteLine("Partition Array: ");
            PrintArray(myArray);
            Console.WriteLine("\n");
            Console.WriteLine($"Pivot Index: {pivotIndex}\n");

            QuickSort(myArray);
            Console.WriteLine("Sorted Array: ");
            PrintArray(myArray);
            Console.WriteLine("\n");
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write($" {i}");
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int biggerCounter = 0;
            int temp, j;

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
    
        static void QuickSort(int[] arr)
        {
            QuickSortRecursive(arr, 0, arr.Length - 1);
        }

        static void QuickSortRecursive(int[] arr, int low, int high)
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
