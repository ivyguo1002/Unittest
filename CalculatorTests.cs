using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act
            int actual = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
        {
            //Arrange
            int expected = 5;
            int numerator = -20;
            int denominator = -4;

            //Act
            int actual = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_PositiveNumeratorAndNegativeDenomitor_ReturnsNegativeQuotient()
        {
            //Arrange
            int expected = -5;
            int numerator = 20;
            int denominator = -4;

            //Act
            int actual = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
