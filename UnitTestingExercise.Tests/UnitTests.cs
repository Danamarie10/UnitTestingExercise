using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var helper = new Helper();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = helper.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData (12, 6, 6)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            

            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal (expected, actual);

        }

        [Theory]
        [InlineData(12, 2, 24)]
        [InlineData(10, 5, 50)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12,2,6)]
        [InlineData (24,12,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var helper = new Helper();
            //Act
            var actual = helper.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
