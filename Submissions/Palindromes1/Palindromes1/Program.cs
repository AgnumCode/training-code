using System;
using System.Text.RegularExpressions;

namespace Palindromes1
{
    class Program
    {

        public static string Tester(string input)
        {
            string pattern = "\\W";

            input.ToLower();
            input = Regex.Replace(input, pattern, String.Empty);

            if (input == StringHelper.ReverseString(input))
            {
                Console.Write(input); Console.Write(" is a Palindrome.");
            }
            else
            {
                Console.Write(input); Console.Write(" isn't a Palindrome.");
            }

            return input;

        }

    }


    static class StringHelper
    {
   
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

    class Palindromes1
    {
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome palindromes!\n");

        Console.WriteLine("Please enter a word.");
        string input = Console.ReadLine();


        Console.WriteLine("Is this your word? (y/n)");
        Console.Write("{0}: ", input);
        string yes_no = Console.ReadLine();
        if (yes_no == "y" || yes_no == "yes")
        {
            Console.WriteLine("Calculating Palindromism... \n");
        }
        else
        {
            Console.WriteLine("Trying again... \n");
        }

        Program.Tester(input);
        Console.ReadLine();

         }
    }

}
