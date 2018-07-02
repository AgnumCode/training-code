using System;

namespace Palindrome.Library
{
    public class Palindrome
    {

        public string IsPalindrome(string str)
        {
            string original = str;
            string reversed = getReversedString(a);

            if(reversed == original)
            {
                Console.WriteLine("This string is Palindrome");
            }
            else
            {
                Console.WriteLine("This string is NOT Palindrome");
            }
           
        }



        public string getReversedString(string a)
        {
            string reversedString = "";
            //string original = a;
            int i = a.Length - 1;

            while ( i >= 0)
            {
                reversedString = reversedString + a[i];
                i--;
            }

            return reversedString;
        }
    }
}
