using RBPalindrome.Library;
using System;
using System.Collections.Generic;
using Xunit;

namespace RBPalindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void PracticeTest()
        {
            var pal = new Palindrome();

            pal.Add("Just checking xD");

        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new string[] { "Racecar", "121" }};
            yield return new object[] { new string[] { "one two onw", "123abccba123" } };
            yield return new object[] { new string[] { "Racecar", "nurses run", "1221", "never odd, or even" } };

        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Palindromecheck(string[] data)
        {
            var pal = new Palindrome();
            pal.AddMany(data);

            foreach (string value in data)
            {
                pal.IsPalindrome(value);
            }
        }

    }
}
