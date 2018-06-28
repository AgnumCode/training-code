using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // reference container like an array 
        static void Lists()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Fred");
            stringList[0] = "Nick";

            List<string> stringList2 = new List<string>() { "Fred", "Nick" };
        }
        
        // no duplicates are allowed and will be deleted
        static void Sets()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 4, 4, 4 };

        }

        // key value pairs 
        static void Dictionaries()
        {
            var wordDict = new Dictionary<string, string>();
            wordDict.Add("apple", "round red fruit");

            var addressbook = new Dictionary<string, string>
            {
                {"Nick", "Sterling, VA" }
            };
            addressbook["Nicke"] = "Reston, VA";
        }

        // traditional arrays
        static void Array()
        { 
            int[] intArray = new int[30];
            intArray[0] = 1;

            //2d array
            int[][] arrayOfArray = new int[10][];

            // allocation multidimensional array
            int[,] multiArray = new int[10, 10];
            multiArray[0, 5] = 3;

            // array intitialization
            multiArray =new int[,] { { 1,2,3}, { 4,5,6} };
        }
    }
}
