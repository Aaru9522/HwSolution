
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator you want to perform on above both numbers:");
            char operation = Console.ReadLine()[0];

            Console.WriteLine("Enter second number");
            double  num2 = Convert.ToDouble(Console.ReadLine());


      

            switch (operation)
                {
                case '+':
                    Console.WriteLine($"Result {num1} + {num2} = {num1 + num2}");                    
                    break;

                case '-':
                    Console.WriteLine($"Result {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Result {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    Console.WriteLine($"Result  {num1} / {num2} = {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;


            }
            Console.ReadLine();
        }
    }
}
