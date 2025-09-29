using System;
using task2;
using Xunit;

namespace task2.Tests
{
    public class RectangleTests
    {
        private static void AssertAlmostEqual(double expected, double actual, double eps = 1e-9)
            => Assert.True(Math.Abs(expected - actual) <= eps, $"Expected {expected}, got {actual}");

        [Fact]
        public void Area_And_Perimeter_Computed_Correctly()
        {
            var rect = new Rectangle(3, 4);

            AssertAlmostEqual(12, rect.Area);      // 3*4
            AssertAlmostEqual(14, rect.Perimeter); // 2*(3+4)
        }

        [Fact]
        public void Square_Area_Perimeter_Correct()
        {
            var rect = new Rectangle(5, 5);

            AssertAlmostEqual(25, rect.Area);
            AssertAlmostEqual(20, rect.Perimeter);
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(5, -1)]
        [InlineData(-1, -1)]
        public void Constructor_Throws_On_Negative_Side(double a, double b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(a, b));
        }
    }
}