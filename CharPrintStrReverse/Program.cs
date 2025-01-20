using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharPrintStrReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Print characters of the string 
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();

            Console.WriteLine("All character of the string are:");

            for (int i = 0; i < str.Length; i++) //loop will work till the full length of string 
            {
               
                Console.WriteLine(str[i]);
            }


            //Reverser String 
            string res = ""; //initialize an empty string 

            for (int i = str.Length -1; i >=0; i--) //iterate though the string in reverse order
            {
                //res = res + str[i];
                res += str[i];
            }
            Console.WriteLine($"The reverse string of {str} is {res}");


            Console.ReadLine();

        }
    }
}
