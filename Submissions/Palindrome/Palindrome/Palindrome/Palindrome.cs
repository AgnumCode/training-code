using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    class Palindrome
    {
        public static bool CheckPalindrome(string str)
        {
            str = "abc cba";
            int maxLength = str.Length - 1;
            bool compare = false;

            for (int i = 0; i < (str.Length/2); i++)
            {
                char forward = str[i];
                char backward = str[maxLength];
                maxLength--;

                if (forward == backward)
                {
                    compare = true;
                }

                else
                {
                    Console.WriteLine("This string is not a palindrome");
                }


            }

            if (compare == true)
            {
                Console.WriteLine("This is a palindrome");
            }
        }
    }
}



