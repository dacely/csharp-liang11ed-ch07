using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch07
{
    class E31_MergeTwoSorted
    {
        public static void Execute()
        {
            Random random = new Random();
            const int SIZE_ARRAY_1 = 5;
            const int SIZE_ARRAY_2 = 20;

            int[] arr1 = new int[SIZE_ARRAY_1];
            int[] arr2 = new int[SIZE_ARRAY_2];

            for (int i = 0; i < SIZE_ARRAY_1; i++)
                arr1[i] = random.Next(1, 200);
            
            for (int i = 0; i < SIZE_ARRAY_2; i++)
                arr2[i] = random.Next(1, 200);

            BubbleSort(arr1);
            BubbleSort(arr2);

            Console.WriteLine("Array 1: ");
            PrintArray(arr1);
            Console.WriteLine("\n");
            
            Console.WriteLine("Array 2: ");
            PrintArray(arr2);
            Console.WriteLine("\n");

            int[] arr3 = MergeTwoSortedArrays(arr1, arr2);
            Console.WriteLine("Merrged arrays: ");
            PrintArray(arr3);
            Console.WriteLine("\n");
            Console.ReadLine();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write($" {i}");
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    
        static int[] MergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            while (i < arr1.Length)
                arr3[k++] = arr1[i++];
            
            while (j < arr2.Length)
                arr3[k++] = arr2[j++];

            return arr3;
        }
    }
}
