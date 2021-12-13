using System;
using System.Collections.Generic;
using System.Text;

namespace _2_quvveti
{
    class _2quvvet
    {
        public int Num;


        public _2quvvet(int num)
        {
            Num = num;
        }

        

        public void Method( int num)
        {
           

            
           while (num!=1)
            {
                
                    if (num%2!=0)
                    {
                    Console.WriteLine( "eded 2 nin quvveti deyil");
                    break;
                    }




                num /= 2;
                


                Console.WriteLine("eded 2 quvvetidir");

            }

           






























        }

    }
}
