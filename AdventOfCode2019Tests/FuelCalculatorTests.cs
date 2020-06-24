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
        public void FuelForIndividualModule(int mass, int expectedAnswer)
        {
            // Arrange
            IFuelCalculator fuelCalc = new FuelCalculator();

            // Act
            int actualAnswer = fuelCalc.FuelForModule(mass);

            // Assert
            Assert.Equal(expectedAnswer, actualAnswer);
        }

        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void Calculates_Fuel_For_Each_Module_With_Fuel(int mass, int expectedAnswer)
        {
            // Arrange
            IFuelCalculator fuelCalc = new FuelCalculator();

            // Act
            int actualAnswer = fuelCalc.FuelForModuleAndFuel(mass);

            // Assert
            Assert.Equal(expectedAnswer, actualAnswer);
        }
    }
}
