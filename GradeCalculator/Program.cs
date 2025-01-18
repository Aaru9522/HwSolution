using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char grade;
            Console.WriteLine("Enter Your Grade (A, B, C, D, E):");

            grade = char.ToUpper(Console.ReadLine()[0]); //read letter and convert to upper case

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Your Grade Points are 4.0");
                    break;

                case 'B':
                    Console.WriteLine("Your Grade Points are 3.0");
                    break;

                case 'C':
                    Console.WriteLine("Your Grade Points are 2.0");
                    break;

                case 'D':
                    Console.WriteLine("Your Grade Points are 1.0");
                    break;

                case 'E':
                    Console.WriteLine("Your Grade Points are 0.0");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

            Console.ReadLine();


        }
    }
}
