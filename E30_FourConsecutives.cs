using System;

namespace Liang_Ch07
{
    class E30_FourConsecutives
    {
        public static void Execute()
        {
            Random rnd = new Random();
            const int ARRAY_SIZE = 100;
            const int MAX_INT = 5;

            int[] myList = new int[ARRAY_SIZE];

            for (int i = 0; i < myList.Length; i++)
                myList[i] = rnd.Next(1, MAX_INT);

            // Print Array
            Console.WriteLine("List of numbers:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"{myList[i],2:D}");
                
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine("\n");

            int counter = 1;
            int indexConsecutiveFour = -1;

            for (int i = 1; i < ARRAY_SIZE; i++)
            {
                if (myList[i] == myList[i - 1])
                    ++counter;
                else
                    counter = 1;

                if (counter == 4)
                {
                    indexConsecutiveFour = i - 2;
                    break;
                }
            }

            if (indexConsecutiveFour >= 0)
            {
                Console.WriteLine("Four consecutive equal numbers \n" +
                        "were found beginning at position {0:D}\n", indexConsecutiveFour);
            }
            else
                Console.WriteLine("The list has no consecutive four numbers");

            Console.ReadLine();
        }
    }
}
