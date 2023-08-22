using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_MatrixIsNull_ReturnNull()
        {
            // Arrange
            int[,] baseMatrix = null;
            // Act
            int[,] result = Matrix.Divide(baseMatrix, 2);
            // Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Divide_NormalTest_Works()
        {
            // Arrange
            int[,] baseMatrix = {{10, 20}, {30, 40}};
            int [,] expected = {{5, 10}, {15, 20}};
            // Act
            int[,] result = Matrix.Divide(baseMatrix, 2);
            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Divide_ByZero_ReturnNullAndPrintsString()
        {
            // Arrange
            int[,] baseMatrix = {{10, 20}, {30, 40}};
            StringWriter stringWriter= new StringWriter();
            Console.SetOut(stringWriter);
            // Act
            int[,] result = Matrix.Divide(baseMatrix, 0);
            string expectedOutput = "Num cannot be 0\n";
            // Assert
            Assert.AreEqual(result, null);
            Assert.AreEqual(expectedOutput, stringWriter.ToString());
            Console.SetOut(Console.Out);
        }
    }
}