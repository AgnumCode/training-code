using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Program1
    {
        /// <summary>
        /// check a string for palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// true if palindrome or false if not
        /// </returns>
        

        public static bool IsPalindrome(string str)
        {

            // Not the best way to trim out character but it mets 
            // requirements and gets the job done
            string trimString = str.Replace(" ", "");
            trimString = trimString.Replace(",", "");

            int min = 0;
            int max = trimString.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = trimString[min];
                char b = trimString[max];

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
