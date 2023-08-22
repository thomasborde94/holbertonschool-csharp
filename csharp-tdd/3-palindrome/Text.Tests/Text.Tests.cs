using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsPalindrome_SIsPalindrome_ReturnTrue()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama.";
            // Act
            bool isPalindrome = Str.IsPalindrome(s);
            // Assert
            Assert.True(isPalindrome);
        }

        [Test]
        public void IsPalindrome_SIsNotPalindrome_ReturnFalse()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama.akx";
            // Act
            bool isPalindrome = Str.IsPalindrome(s);
            // Assert
            Assert.False(isPalindrome);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnFalse()
        {
            // Arrange
            string s = "";
            // Act
            bool isPalindrome = Str.IsPalindrome(s);
            // Assert
            Assert.True(isPalindrome);
        }
    }
}