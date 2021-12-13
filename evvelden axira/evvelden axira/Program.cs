using System;

namespace evvelden_axira
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Array.Reverse(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

        }




       
        
    }
}
