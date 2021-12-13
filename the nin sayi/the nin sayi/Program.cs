using System;

namespace the_nin_sayi
{
    class Program
    {
        static void Main(string[] args)
        {


            The("the home is clear which next to the hotel");


        }



        static void The(string word)
        {
             word = "the home is clear  which next to the hotel";
            string word1 = "the";
            string[] str = word.Split(' ');
            int count = 0;
            foreach (var item in str)
            {
                if (item==word1)
                {
                    count++;
                }

               
            }
            Console.WriteLine(count);
        }

        
        
    }
}
