using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPower_SumOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Power of a number
            Console.WriteLine("Enter the base (b):");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent (p):");
            int p = Convert.ToInt32(Console.ReadLine());

            decimal result = Power(b, p);

            Console.WriteLine($"{b}^{p} = {result}");


            //Sum of first 'n' Natural numbers
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = SumOfNaturalNum(n);
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");



            Console.ReadLine();
        }

        static decimal Power(int b, int p)
        {
            if (p == 0)
            {
                return 1;
            }
            else
            {
                // b^p = x * b^(p-1)
                return b * Power(b, p-1);
            }
        }

        static int SumOfNaturalNum(int n)
        {
            if (n == 1) // natural numbers starts from 1
            {
                return 1;
            }
            else
            {
                // n + sum of fisrt (n-1)
                return n + SumOfNaturalNum(n-1);
            }
        }
    }
}
