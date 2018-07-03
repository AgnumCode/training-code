using System;
using Xunit;
using Palindrome.Library;


namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void Test1()
        {

            // Arrange
            Program1.IsPalindrome("deified");

            // Act
            Program1.IsPalindrome("civic");

            // Assert
            Assert.True(Program1.IsPalindrome("racecar"));

            // Assert
            Assert.True(Program1.IsPalindrome("raCecaR"));
            Assert.True(Program1.IsPalindrome("never odd, or even"));
            Assert.True(Program1.IsPalindrome("race  car"));
            Assert.True(Program1.IsPalindrome("never odd,    or  even"));








        }
    }
}
