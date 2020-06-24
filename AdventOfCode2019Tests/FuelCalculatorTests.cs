using System;
using Xunit;
using AdventOfCode2019;

namespace AdventOfCode2019Tests
{
    public class FuelCalculatorTests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void Test1(int mass, int expectedAnswer)
        {
            // Arrange
            IFuelCalculator fuelCalc = new FuelCalculator();

            // Act
            int actualAnswer = fuelCalc.FuelForModule(mass);

            // Assert
            Assert.Equal(expectedAnswer, actualAnswer);
        }
    }
}
