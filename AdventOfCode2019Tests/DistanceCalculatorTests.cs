using AdventOfCode2019;
using AdventOfCode2019.Entities;
using Xunit;

namespace AdventOfCode2019Tests
{
    public class DistanceCalculatorTests
    {
        [Theory]
        [InlineData(12, -122, 11, -101, 22)]
        [InlineData(201, -122, -10009, -101, 10231)]
        public void Can_Calculate_Manhatten_Distance(int x1, int y1, int x2, int y2, int expectedResult)
        {
            // Arrange
            DistanceCalculator calc = new DistanceCalculator();
            Coordinate pos1 = new Coordinate(x1, y1);
            Coordinate pos2 = new Coordinate(x2, y2);
            // Act
            int actualResult = calc.CalculateManhattenDistance(pos1, pos2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}