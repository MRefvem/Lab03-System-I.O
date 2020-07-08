using System;
using Xunit;
using static CSharpReview.Program;

namespace CSharpReviewTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 3, 3 }, 27)]
        public void ProdTest(int[] arr, int expected)
        {
            Assert.Equal(expected, MultiplyInputNumber(arr));
        }

        [Fact]
        public void CanReturnZero()
        {
            // Arrange
            string input = "cat";

            // Act
            int outputFromMethod = MultiplyInputNumber(input);

            // Assert
            Assert.Equal(0, outputFromMethod);
        }

        [Fact]
        public void CanReturnProductWithThreeNumbers()
        {
            // Arrange
            string numbers = "2 3 4";

            // Act
            int output = MultiplyInputNumber(numbers);

            // Assert
            Assert.Equal(24, output);
        }

        [Fact]
        public void InputMoreThanThreeNumbers()
        {
            // Arrange
            string numbers = "3 4 5 6";

            // Act
            int output = MultiplyInputNumber(numbers);

            // Assert
            Assert.Equal(60, output);
        }
    }
}
