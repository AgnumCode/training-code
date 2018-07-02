using System;

namespace Palindrome.Library
{
    public class Palindrome
    {
        public bool IsPalindrom(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            var reversedStr = new string(arr);

            if(reversedStr.Equals(str))
                return true;
            else
                return false; 
        }

      
    }
}
