using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(2, 5, 6, 13)]
        [InlineData(2, 0, 6, 8)]
        [InlineData(-2, -5, 6, -1)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            //Act
            var actual = unitTest.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 12, -2)]
        [InlineData(12, 10, 2)]
        [InlineData(0, 0, 0)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            //Act
            var actual = unitTest.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 12, 120)]
        [InlineData(12, -10, -120)]
        [InlineData(8, 1, 8)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            //Act
            var actual = unitTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 8, 0)]
        [InlineData(8, 6, 1)]
        [InlineData(12, 3, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            //Act
            var actual = unitTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Laugh()
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            var expected = "Ha ha!";
            //Act
            var actual = unitTest.Laugh();
            //Assert
            Assert.Equal(expected, actual);
            

        }

        [Fact]
        public void Yell()
        {
            //Arrange
            var unitTest = new UnitTestMethods();
            var expected = "Hey!";
            //Act
            var actual = unitTest.Yell();
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
