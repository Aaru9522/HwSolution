using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNaturalNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of natural number:");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= a; i++)
            {
                sum += i;
            }
           // Console.WriteLine($"The sum of the first {a} natural numbers is: {sum}");
           Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
       
    }
}
