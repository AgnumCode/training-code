using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome.Library
{
   public class Palindromes
    {
        static class StringHelper
        {
     
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }

        }

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
}
