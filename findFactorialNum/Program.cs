using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findFactorialNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for factorial value:");
            int a = Convert.ToInt32(Console.ReadLine());

            int factorial = 1; //can not use 0 

            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }

            //Console.WriteLine("The factorial value is:" + factorial);
            Console.WriteLine($"The factorial value of {a} is: {factorial}");
            Console.ReadLine();
        }
    }
}
