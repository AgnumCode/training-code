using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeDetector.Library
{
    class Palindrome
    {


            public Palindrome()
            {

            }
        
            public static bool IsPalindrome(string value)
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


        
    }
}
