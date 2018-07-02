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
            string value = "racecar";
            bool expected = true;
            bool actual;

            PalindromeDetector detector = new PalindromeDetector();
            actual = detector.IsPalindrome(value);



        }
    }
}
