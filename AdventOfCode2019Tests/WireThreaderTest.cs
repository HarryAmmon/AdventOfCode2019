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
        [InlineData(10, 10)]
        public void Can_Thread_Wire_X_Positive_Direction(int magnitude, int expectedXPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadXPositive(magnitude);

            // Assert
            Assert.Equal(expectedXPosition, _wire.currentPosition.x);
        }


        [Theory]
        [InlineData(2, -2)]
        [InlineData(10, -10)]
        public void Can_Thread_Wire_X_Negative_Direction(int magnitude, int expectedXPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadXNegative(magnitude);

            // Assert
            Assert.Equal(expectedXPosition, _wire.currentPosition.x);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(10, 10)]
        public void Can_Thread_Wire_Y_Positive_Direction(int magnitude, int expectedYPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadYPositive(magnitude);

            // Arrange
            Assert.Equal(expectedYPosition, currentLocation.y);
        }

        [Theory]
        [InlineData(2, -2)]
        [InlineData(10, -10)]
        public void Can_Thread_Wire_Y_Negative_Direction(int magnitude, int expectedYPosition)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act
            Coordinate currentLocation = wireThreader.ThreadYNegative(magnitude);

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
            IInstructionDecoder decoder = new InstructionDecoder();

            // Act
            Vector vector = decoder.VectorDecoder(instruction);

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
            IInstructionDecoder decoder = new InstructionDecoder();

            // Act
            Vector vector = decoder.VectorDecoder(instruction);

            // Assert
            Assert.Equal(expectedMagnitude, vector.Magnitude);
        }

        [Theory]
        [InlineData("L", 10, -10, 0)]
        [InlineData("R", 10, 10, 0)]
        [InlineData("U", 10, 0, 10)]
        [InlineData("D", 10, 0, -10)]
        public void WireThreader_Threads_Correct_Direction_Given_Vector(string direction, int magnitude, int expectedX, int expectedY)
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);
            Vector vector = new Vector(direction, magnitude);
            Coordinate coord = new Coordinate(expectedX, expectedY);

            // Act
            Coordinate result = wireThreader.Thread(vector);

            // Assert
            Assert.Equal(coord.x, result.x);
            Assert.Equal(coord.y, result.y);
        }
    }
}