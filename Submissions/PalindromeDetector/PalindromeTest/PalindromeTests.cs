using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeDetector.Library;


namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void TestCorrectPalindromeDetection()
        {
            // Arrange
            string value = "racecar";
            object expected = true;
            object actual;

            // Act
            PalindromeDetector detector = new PalindromeDetector();
            actual = detector.IsPalindrome(value);

            // Assert
            Assert.AreEqual(expected, actual, "Palindrome Detector returned false result");

        }
    }
}
