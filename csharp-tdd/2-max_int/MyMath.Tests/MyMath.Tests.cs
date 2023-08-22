using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {

        [Test]
        public void Max_NormalCase_ReturnMaxInt()
        {
            // Arrange
            List<int> myList = new List<int>{-7, 12, 24, 0, 9065};
            // Act
            int highest = Operations.Max(myList);
            // Assert
            Assert.AreEqual(highest, 9065);
        }

        [Test]
        public void Max_ListEmpty_ReturnZero()
        {
            // Arrange
            List<int> myList = new List<int>();
            // Act
            int highest = Operations.Max(myList);
            // Assert
            Assert.AreEqual(highest, 0);
        }
    }
}