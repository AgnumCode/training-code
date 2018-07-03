using System;
using Xunit;
using Palindromes.Library;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsPalindromeShouldReturnTrue()
        {
            string word = "nurses run";
            bool result = Palindromes.Library.Palindrome.IsPalindrome(word);
            bool expected = true;
            Assert.Equal(expected, result);
        }
    }

}
