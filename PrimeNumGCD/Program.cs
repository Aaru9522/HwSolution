using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("This is not prime number");
                
            }
            else
            {

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("This is not prime number");
                        return;                       

                    }

                }
                Console.WriteLine("This is prime number");              
                
            }
            Console.ReadLine();
        }
    }
}
