using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DayofTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekdayNum;


            Console.WriteLine("Enter the weekday Number (1-7): ");
            weekdayNum = Convert.ToInt32(Console.ReadLine()); //for converting string to int as readline always gives string
           
            switch (weekdayNum)
            {
                case 1:
                    Console.WriteLine("It is Sunday");
                    break;

                case 2:
                    Console.WriteLine("It is Monday");
                    break;

                case 3:
                    Console.WriteLine("It is Tuesday");
                    break;

                case 4:
                    Console.WriteLine("It is Wednesday");
                    break;

                case 5:
                    Console.WriteLine("It is Thursday");
                    break;

                case 6:
                    Console.WriteLine("It is Friday");
                    break;

                case 7:
                    Console.WriteLine("It is Saturdayday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadLine();


        }
    }
}
