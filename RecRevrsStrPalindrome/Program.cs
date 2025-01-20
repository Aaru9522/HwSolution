using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecRevrsStrPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print reverse string
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();

            string reversed = ReverseString(str);

            Console.WriteLine($"The reversed string is: {reversed}");


            //Palindrome check 
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine("The String is a Palindrome...");
            }
            else
            {
                Console.WriteLine("The String is not a Palindrome");
            }

            Console.ReadLine();
        }

        static string ReverseString(string str)
        {
            if(str.Length <= 1) //if string is empty or has 1 character return it
            {  
                return str;
            }

            //reverse the rest of string by appedning the 1st char to end
            /*char firstletter = str[0];
            string rest = str.Substring(1);

            return ReverseString(rest) + firstletter;*/
            return ReverseString(str.Substring(1)) + str[0];            
                            
        }

        static bool IsPalindrome(string input)
        {
            //if str has 0 or 1 character
            if (input.Length <= 1)
                return true;

            //if 1st and last characters are not same
            if (input[0] != input[input.Length - 1])
                return false;

            //check substring except of first and last characters
            return IsPalindrome(input.Substring(1, input.Length - 2));
        }


    }
}
