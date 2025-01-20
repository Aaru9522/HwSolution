using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecFibonaciiGcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print nth Fibonacci number
            Console.WriteLine("Enter the term number to get the nth Fibonacci Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            decimal result = Fibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {result}");

            //Find GCD using Euclid's algorithm
            Console.WriteLine("Enter the 1st Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int gcd = GCD(n1, n2);

            Console.WriteLine($"The GCD of {n1} and {n2} is: {gcd}");



            Console.ReadLine();
        }


            // recusrive functions 
        static decimal Fibonacci (int n)
        {
            if (n == 0)
                return 0;
            if(n == 1) 
                return 1;

            // F(n) = F(n-1)+F(n-2)

            return Fibonacci(n-1) + Fibonacci(n-2);
        }

        static int GCD(int n1, int n2)
        {
            if (n2 == 0) //if n2 is 0 then GCD is n1
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
    }
}
