using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Text.Tests
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void UniqueChar_allLowerCase_Works()
        {
            // Arrange
            string s = "my name is john";
            // Act
            int index = Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(index, 1);
        }

        [Test]
        public void UniqueChar_SomeUpperCase_Works()
        {
            // Arrange
            string s = "My Name is john";
            // Act
            int index = Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(index, 0);
        }

                [Test]
        public void UniqueChar_NoOccurence_ReturnsMinusOne()
        {
            // Arrange
            string s = "MYLPMYLP";
            // Act
            int index = Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(index, -1);
        }
    }
}