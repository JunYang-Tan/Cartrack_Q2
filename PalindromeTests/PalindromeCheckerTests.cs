using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cartrack_Question_2;

namespace PalindromeCheckerTests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void Testing()
        {
            var palindrome = new Program.PalindromeTester();
            string x = "madam";
            var expected = true;
            var result = palindrome.Checker(x);

            Assert.AreEqual(expected, result);
        }
    }
}
