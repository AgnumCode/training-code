using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeDetector
{

    public class Palindrome
    {
        private readonly string strValue;

        public Palindrome(string value)
        {
            strValue = value;
        }
        
            public bool IsPalindrome(string value)
            {
                int min = 0;
                int max = value.Length - 1;
                while (true)
                {
                    if (min > max)
                    {
                        return true;
                    }
                    char a = value[min];
                    char b = value[max];
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                    min++;
                    max--;
                }
            }


        static void Main(String[] args)
        {
            string str = "racecar";
            Palindrome detector = new Palindrome(str);
            bool palindromeResult = detector.IsPalindrome(str);
            Console.WriteLine("Is the string a Palindrome?" + palindromeResult);
        }
        
    }
}
