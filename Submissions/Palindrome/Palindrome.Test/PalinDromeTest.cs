using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void PalindromeWithEmptyString()
        {

            // arrange 
            string str = "";
            
            // act

            // assert 

        }

        [Fact]
        public void PalindromeWithTruePalindrome()
        {
            // arrange
            string str = "nurses run";

            // act

            // assert

        }

        [Fact]
        pubilc void PalindromeWithFalsePalindrome()
        {
            // arrange
            string str = "one two one";

            // act 

            // assert
        }
    }
}
