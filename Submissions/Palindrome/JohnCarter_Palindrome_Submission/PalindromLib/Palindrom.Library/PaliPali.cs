﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
  public class PaliPali
    {
        public string paliControl; 
   
       
        public string PaliChecker(string pali)
        {
            paliControl = pali;
            char[] paliToArray = pali.ToCharArray();
            Array.Reverse(paliToArray);
            string paliBackToString = new string(paliToArray);
            //return new string(paliToArray);
            if (pali == paliBackToString)
            {
                return "palindrome";
            }
            else
            {
                return ("not a palindrome");
            }
        }



    }
}
