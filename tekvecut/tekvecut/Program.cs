using System;

namespace tekvecut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 ,6, 7, 8, 9, 10 };
            int[] arr2 = new int[5];

            foreach (var item in arr)
            {
                if (item %2==0)
                {
                    
                }

                else if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
