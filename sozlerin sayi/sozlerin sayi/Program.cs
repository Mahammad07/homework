using System;

namespace sozlerin_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "this is cod academy";
            int count = 0;
            string[] str = word.Split(' ');
            foreach (var item in str)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
