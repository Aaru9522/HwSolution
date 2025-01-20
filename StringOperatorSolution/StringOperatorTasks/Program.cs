using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperatorTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Reverse a String
            //Input: "hello" → Output: "olleh"
            string abc = "Hello";
            string reversed = new string (abc.Reverse().ToArray());
            Console.WriteLine("Reversed String is:" + reversed);


            //2.Check if a String is a Palindrome
            //Input: "madam" → Output: true

            string input = "madam";
            bool isPallindrome = input.SequenceEqual(input.Reverse());
            Console.WriteLine($"Is \"{input}\" a pallindrome? {isPallindrome}");


            //3.Count the Number of Vowels and Consonants
            //Input: "OpenAI" → Output: Vowels: 3, Consonants: 3

            string input1 = "OpenAI";
            int vowels = 0;
            int consonants = 0;

            foreach (char c in input1.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowels++;

                else if (char.IsLetter(c))
                    consonants++;
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");



            //4.Find the Frequency of Each Character in a String
            //Input: "apple" → Output: a: 1, p: 2, l: 1, e: 1
            string str = "apple";
            string processed = ""; //to keep track of processed characters

            foreach(char c in str)
            {
                if(!processed.Contains(c)) //process each chatracters only once
                { 
                int count = str.Split(c).Length - 1; //count the occurance of char
               
                
                    Console.WriteLine($"{c}: {count}");
                    processed += c; //mark the char is processed
                }


            }


            //5.Check if Two Strings are Anagrams
            //Input: "listen", "silent" → Output: true

            string str1 = "listen";
            string str2 = "silent";

            bool areAnagrams = str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));//order in alphabatical and compare all characters in both string
            Console.WriteLine($"Are {str1} and {str2} anagrams?: {areAnagrams}");





            //6.Remove All White Spaces from a String
            //Input: "Hello World" → Output: "HelloWorld"

            string input2 = "Hello World";
            string result = input2.Trim().Replace(" ","");

            Console.WriteLine(result);




            //7.Find the Longest Word in a Sentence
            //Input: "The quick brown fox" → Output: "quick"

            string input3 = "The quick brown fox";
            string longWord = input3.Split(' ').OrderByDescending(word => word.Length).First(); //split sentence and find the word

            Console.WriteLine($"The longest word is: {longWord}");



            //8.Count the Number of Words in a String
            //Input: "C# is awesome" → Output: 3

            string input4 = "c# is awesome";
            int wordCount = input4.Split(' ').Length;
            Console.WriteLine(wordCount);



            //9.Replace All Occurrences of a Character in a String
            //Input: "banana", Replace "a" with "o" → Output: "bonono"
            string input5 = "banana";
            string replace = input5.Replace('a', 'o');
            Console.WriteLine(replace);



            //10.Check if a String Contains Only Digits
            //Input: "12345" → Output: true
            string input6 = "12345";
            bool isDigitOnly = input6.All(char.IsDigit);

            Console.WriteLine(isDigitOnly);

            Console.ReadLine();
        }
    }
}
