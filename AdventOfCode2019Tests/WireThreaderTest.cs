using System;
using AdventOfCode2019;
using AdventOfCode2019.Entities;
using Xunit;

namespace AdventOfCode2019Tests
{
    public class WireThreaderTest
    {
        private Wire _wire;
        public WireThreaderTest()
        {
            _wire = new Wire(0, 0);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(-10, -10)]
        public void Can_Thread_Wire_X_Direction(int vector, int expectedXPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadX(vector);

            // Assert
            Assert.Equal(expectedXPosition, _wire.currentPosition.x);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(-10, -10)]
        public void Can_Thread_Wire_Y_Direction(int vector, int expectedYPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadY(vector);

            // Arrange
            Assert.Equal(expectedYPosition, currentLocation.y);
        }
    }
}