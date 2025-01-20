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




            // Print GCD 

            Console.WriteLine("Enter the 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = 1;

            int min = Math.Min(num1, num2); //finding the smaller num

            for (int i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)  // checking if i is a common divisor
                {
                    gcd = i;

                }
            }

            Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");



            Console.ReadLine();
        }
    }
}
