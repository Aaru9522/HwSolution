using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusrionOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recusrive method for factorial value
            Console.WriteLine("Enter a number to calculate its factorial value:");
            int number = Convert.ToInt32(Console.ReadLine());

            decimal f = Factorial(number);

            Console.WriteLine($"The factorial of {number} is: {f}");

            Console.ReadLine();
        }

       

        static decimal Factorial(int n) 
        {
            /*int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;*/

            if (n == 0 || n == 1) //factorial of o and 1 is 1
            {
                return 1;
            }
            else
            {
                return n * Factorial(n -1);
            }
        }

    }
}
