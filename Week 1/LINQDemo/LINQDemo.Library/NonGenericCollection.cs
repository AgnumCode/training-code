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
            list.AddRange(strings);
<<<<<<< HEAD
        }   
        
        public string Longest()
        {
            // var example = new { s = "abc", l = "abc".Length };
            //method syntax
            List<int> listOfLengths = list.Select(s => s.Length).ToList();
            // method syntax
            var listWithAwfulSyntax = (from item in list
                                      where item.Length > 2
                                      select item.Length).ToList();
=======
        }

        public string Longest()
        {
            //var example = new { s = "abc", l = "abc".Length };
            // method syntax
            List<int> listOfLengths = list.Select(s => s.Length).ToList();
            // query syntax
            List<int> listWithAwfulSyntax = (from item in list
                                             where item.Length > 2
                                             select item.Length).ToList();

>>>>>>> master
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
<<<<<<< HEAD
        
=======

>>>>>>> master
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
<<<<<<< HEAD
            
=======
>>>>>>> master
            return list.Sum(s =>
                s.Count(c =>
                    "aeiouAEIOU".Contains(c)
                )
            );
        }

        public string ThirdAlphabetical()
        {
<<<<<<< HEAD
            //linq deferred execution
            var query = list.OrderBy(x => x).Skip(2);       // orders and drops first 2 from list
            return query.First();                           // returns first element of list 
=======
            // linq deferred execution
            IEnumerable<string> query = list.OrderBy(x => x).Skip(2);
            return query.First();
>>>>>>> master
        }

        public bool Contains(string item)
        {
            // null check code
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
<<<<<<< HEAD

            return list.Contains(item);
        }

=======
            return list.Contains(item);
        }
>>>>>>> master
    }
}
