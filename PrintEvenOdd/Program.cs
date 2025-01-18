using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print Even numbers between 1 to 100

            Console.WriteLine("The Even Numbers Bewteen 1 to 100 are as follows:");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2== 0)
                {
                    Console.WriteLine(i);
                    
                }
                
            }

            Console.WriteLine("The Odd Numbers Between 1 to 50 are as follows:");

            for(int i = 0;i <= 50;i++)
            {  
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
