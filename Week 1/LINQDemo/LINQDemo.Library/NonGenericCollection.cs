using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDemo.Library
{
    public class NonGenericCollection
    {
        private readonly List<string> list = new List<string>();

        public void Add(string s)
        {
            list.Add(s);
        }

        public void AddMany(IEnumerable<string> strings)
        {
            if (strings == null)
            {
                throw new ArgumentNullException(nameof(strings));
            }

            list.AddRange(strings);
        }

        public string Longest()
        {
            // Anonymous Type (very important) and have to use "var"
            // var example = new { s = "abc", l = "abc".Length };

            //Select function is kind of borrowed from SQL to map element

            // another example
            //var listOfLenghts = list.Select(s => s.Length).ToList();

            //var itemLengthPairs = list.Select(s => new { s, l = s.Length });

            //var maxLengthPair = itemLengthPairs.Max(a => a.l);

            //var result = maxLengthPair.

            // method syntax
            List<int> listOfLengths = list.Select(s => s.Length).ToList();
            // query syntax
            //var listWithAwfulSyntax = from item in list where item.Length > 2 select item.Length;
            var listWithAwfulSyntax = (from item in list where item.Length > 2 select item.Length).ToList();


            var length = LongestLength();
            return list.First(s => s.Length == length);
        }

        public string DumbLongest()
        {
            int longestLength = 0;
            string longest = null;

            foreach (var item in list)
            {
                if (item.Length > longestLength)
                {
                    longestLength = item.Length;
                    longest = item;
                }
            }

            return longest;
        }

        public int LongestLength()
        {
            return list.Max(x => x.Length);
        }

        public double AverageLength()
        {
            return list.Average(s => s.Length);
        }

        public int TotalVowelCount()
        {
            return list.Sum(s =>
                s.Count(c =>
                    "aeiouAEIOU".Contains(c)
                )
            );
        }

        public string ThirdAlphabetical()
        {
            // linq deferred execution
            IEnumerable<string> query = list.OrderBy(x => x).Skip(2);
            return query.First();
        }

        public bool Contains(string item)
        {
            // null check code
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            return list.Contains(item);
        }
    }
}