using System;

namespace ceminferqi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int result = 0;
            int result2 = 0;
                int[] arr = { 234, 77, 725 ,87};

                for (int i = 0; i <= arr.Length - 1; i++)

                {
                
                if (1000>arr[i] > 99)
                    {
                        result += arr[i];
                    }
                    else
                    {
                    result2 += arr[i];
                    }

                
            }
            Console.WriteLine(result - result2);




        }



    }

   
















}
