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

        [Theory]
        [InlineData("R123", "R")]
        [InlineData("L123", "L")]
        [InlineData("U123", "U")]
        [InlineData("D123", "D")]
        public void Decoding_Instruction_Returns_Direction(string instruction, string expectedDirection)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Vector vector = wireThreader.Decode(instruction);

            // Assert
            Assert.Equal(expectedDirection, vector.Direction);
        }

        [Theory]
        [InlineData("R123", 123)]
        [InlineData("L124", 124)]
        [InlineData("U125", 125)]
        [InlineData("D126", 126)]
        public void Decoding_Instruction_Returns_Magnitude(string instruction, int expectedMagnitude)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Vector vector = wireThreader.Decode(instruction);

            // Assert
            Assert.Equal(expectedMagnitude, vector.Magnitude);
        }
    }
}