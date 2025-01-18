using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTableFibonaciiSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print multiplication table of given number

            Console.WriteLine("Enter any number:");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = a * i;
                Console.WriteLine(a + "x" + i + "=" + result);
            }




            // Print Fibonacci Series

            Console.WriteLine("Enter the number of terms(n):");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1; // intializing first two numbers of series 0 and 1
      

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(first); // for printing first number

                first = first + second; //calculate next num
                second = first - second; //update second to previous number


                //Console.WriteLine(first);

                //int next = first + second; //store sum of previous two numbers
                //first = second; //first updated to second
                //second = next; //second updated to next

            }
            Console.ReadLine();

        }
    }
}
