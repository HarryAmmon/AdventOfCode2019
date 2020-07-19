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
        public void Run_IntCode_Program(int[] _programCode, int[] expectedAnswer)
        {
            // Arrange
            _computer = new IntCodeComputer(_programCode);
            // Act 
            int[] result = _computer.RunProgramCode();
            // Assert
            Assert.Equal(expectedAnswer, result);
        }

        [Fact]
        public void Run_Program_Code_Replaces_The_Noun()
        {
            // Arrange
            int[] programCode = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            IntCodeComputer computer = new IntCodeComputer(programCode);
            int noun = 2;
            int verb = 3;

            // Act
            computer.RunProgramCode(noun, verb);

            // Assert
            Assert.Equal(noun, computer._programCode[1]);
        }

        [Fact]
        public void Run_Program_Code_Replaces_The_Verb()
        {
            // Arrange
            int[] programCode = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            IntCodeComputer computer = new IntCodeComputer(programCode);
            int noun = 2;
            int verb = 3;

            // Act
            computer.RunProgramCode(noun, verb);

            // Assert
            Assert.Equal(verb, computer._programCode[2]);
        }
        [Fact]
        public void Calling_ResetProgramCode_Reverts_ProgramCode()
        {
            // Arrange
            int[] programCode = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            int[] originalProgramCode = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            IntCodeComputer computer = new IntCodeComputer(programCode);

            // Act
            computer.RunProgramCode();
            computer.ResetProgramCode();

            // Assert
            Assert.Equal(originalProgramCode, computer._programCode);

        }
    }
}