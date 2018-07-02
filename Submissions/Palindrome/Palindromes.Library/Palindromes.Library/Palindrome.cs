using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Library
{

    public class Palindrome
    {
        public Palindrome(){}

        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }
        }
    } 
}
