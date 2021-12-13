using System;

namespace array_birlestirme
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 6, 3, 10, 5 };
            int[] arr2 = { 2,7,3,9,4 };

            int[] combined = new int[arr.Length + arr2.Length];
            Array.Copy(arr, combined, arr.Length);
            Array.Copy(arr2, 0,combined, arr.Length,arr2.Length);
            Array.Sort(combined);
            foreach (var item in combined)
            {
                Console.WriteLine(item);
            }
        }
    }
}
