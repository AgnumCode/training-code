using System;
using Palindrome.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isPalindromeTest()
        {
            Palindrome.isPalindrome("aabb");
        }
    }
}
