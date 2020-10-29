using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch07
{
    class E33_MonthName
    {
        public static void Execute()
        {
            Console.Write("Enter month number (1 - 12): ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = {"January", "February" , "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December"};
            Console.WriteLine("Month name: {0}", names[n - 1]);
        }
    }
}
