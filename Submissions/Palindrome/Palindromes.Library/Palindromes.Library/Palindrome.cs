using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Library
{

    public class Palindrome
    {
        public static bool IsPalindrome(string str)
        { 
                string rev = "";
                //string [] words

                for (int i = input1.Length - 1; i >= 0; i--)
                {
                    rev += input1[i];
                }

                if (str.ToLower() == rev.ToLower())
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

        }
        
    }
}
