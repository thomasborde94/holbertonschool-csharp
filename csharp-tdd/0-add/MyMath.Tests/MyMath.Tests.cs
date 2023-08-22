using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_PositivInts_Works()
        {
            // Arrange
            int a = 3;
            int b = 7;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Add_PositivAndNegativInts_Works()
        {
            // Arrange
            int a = -3;
            int b = 7;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(4, result);
        }


        [Test]
        public void Add_NegativInts_Works()
        {
            // Arrange
            int a = -7;
            int b = -17;
            // Act
            int result = Operations.Add(a, b);
            // Assert
            Assert.AreEqual(result, -24);
        }
    }
}