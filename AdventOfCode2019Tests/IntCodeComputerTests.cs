using AdventOfCode2019;
using Xunit;

namespace AdventOfCode2019Tests
{
    public class IntCodeComputerTests
    {
        private int[] _programCode;
        private IIntCodeComputer _computer;

        [Theory]
        [InlineData(1, 2, 3, 30)]
        public void Addition(int inputLocationOne, int inputLocationTwo, int outputLocation, int expectedAnswer)
        {
            // Arrange
            _programCode = new int[] { 0, 4, 5, 6, 10, 20, 0 };
            _computer = new IntCodeComputer(_programCode);

            // Act
            int result = _computer.Addition(_programCode[inputLocationOne], _programCode[inputLocationTwo], _programCode[outputLocation]);

            // Assert
            Assert.Equal(expectedAnswer, result);
        }

        [Theory]
        [InlineData(1, 2, 3, 200)]
        public void Multiplication(int locationOne, int locationTwo, int locationThree, int expectedAnswer)
        {
            // Arrange
            _programCode = new int[] { 0, 4, 5, 6, 10, 20, 0 };
            _computer = new IntCodeComputer(_programCode);

            // Act
            int result = _computer.Multiplication(_programCode[locationOne], _programCode[locationTwo], _programCode[locationThree]);

            // Assert
            Assert.Equal(expectedAnswer, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 0, 0, 0, 99 }, new int[] { 2, 0, 0, 0, 99 })]
        [InlineData(new int[] { 2, 3, 0, 3, 99 }, new int[] { 2, 3, 0, 6, 99 })]
        [InlineData(new int[] { 2, 4, 4, 5, 99, 0 }, new int[] { 2, 4, 4, 5, 99, 9801 })]
        [InlineData(new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }, new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 })]
        public void RunIntCodeProgram(int[] _programCode, int[] expectedAnswer)
        {
            // Arrange
            _computer = new IntCodeComputer(_programCode);
            // Act 
            int[] result = _computer.RunProgramCode();
            // Assert
            Assert.Equal(expectedAnswer, result);
        }
    }
}