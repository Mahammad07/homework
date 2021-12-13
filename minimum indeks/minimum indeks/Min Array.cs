using System;
using System.Collections.Generic;
using System.Text;

namespace minimum_indeks
{
    class Min_Array
    {
        int[] arr = { 2, 5, 8, 12, 54, 67, 90 };

        public void findMin()
        {
            int min = arr.[0];
            int index = Array.IndexOf(arr,min);
            Console.WriteLine($"min={min}");
            Console.WriteLine($"index={index}"); ;
        }
    }
}
