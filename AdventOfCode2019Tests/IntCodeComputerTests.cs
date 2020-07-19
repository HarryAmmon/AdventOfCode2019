using AdventOfCode2019;
using Xunit;

namespace AdventOfCode2019Tests
{
    public class IntCodeComputerTests
    {
        private int[] _programCode;
        private IIntCodeComputer _computer;
        public IntCodeComputerTests()
        {
            _programCode = new int[] { 0, 4, 5, 6, 10, 20, 0 };
            _computer = new IntCodeComputer(_programCode);
        }

        [Theory]
        [InlineData(1, 2, 3, 30)]
        public void Addition(int inputLocationOne, int inputLocationTwo, int outputLocation, int expectedAnswer)
        {
            // Arrange

            // Act
            int result = _computer.Addition(inputLocationOne, inputLocationTwo, outputLocation);

            // Assert
            Assert.Equal(expectedAnswer, result);
        }

        [Theory]
        [InlineData(1, 2, 3, 200)]
        public void Multiplication(int locationOne, int locationTwo, int locationThree, int expectedAnswer)
        {
            // Arrange

            // Act
            int result = _computer.Multiplication(locationOne, locationTwo, locationThree);

            // Assert
            Assert.Equal(expectedAnswer, result);
        }

        [Theory]
        [InlineData()]
        public void RunIntCodeProgram()
        {
            // Arrange

            // Act 

            // Assert

        }
    }
}