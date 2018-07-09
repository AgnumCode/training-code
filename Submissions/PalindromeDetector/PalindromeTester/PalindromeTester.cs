using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeDetector;

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
            Palindrome detector = new PalindromeDetector.Palindrome(value);

            // Act
            actual = detector.IsPalindrome(value);

            // Assert
            Assert.AreEqual(expected, actual, "Palindrome Detector worked incorrectly");
        }
    }
}
