using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeDetector.Library;

namespace PalindromeTester
{
    [TestClass]
    public class PalindromeTester
    {
        [TestMethod]
        public void PalindromeCorrect()
        {
            // Arrange
            string value = "racecar";
            object expected = true;
            object actual = false;

            // Act
            PalindromeTester detector = new PalindromeDetector.Library.Palindrome();
            
            // Assert
            detector.isPalindrome(value);
            Assert.AreEqual(expected, actual, "Palindrome Detector worked incorrectly");
        }
    }
}
