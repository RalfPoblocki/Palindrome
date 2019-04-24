using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void HasDigitOrSpecialCharacter_NoSpecialCharacter_false()
        {
            string input = "test";
            var charArray = input.ToCharArray();
            var result = Program.HasDigitOrSpecialCharacter(charArray);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void HasDigitOrSpecialCharacter_Digit_True()
        {
            string input = "1test";
            var charArray = input.ToCharArray();
            var result = Program.HasDigitOrSpecialCharacter(charArray);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HasDigitOrSpecialCharacter_SpecialCharacter_True()
        {
            string input = "$hallo";
            var charArray = input.ToCharArray();
            var result = Program.HasDigitOrSpecialCharacter(charArray);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPalindrome_Palindrome_True()
        {
            string input = "Wow";
            var charArray = input.ToCharArray();
            var result = Program.IsPalindrome(input, charArray);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPalindrome_NoPalindrome_False()
        {
            string input = "hallo";
            var charArray = input.ToCharArray();
            var result = Program.IsPalindrome(input, charArray);

            Assert.AreEqual(false, result);
        }
    }
}
