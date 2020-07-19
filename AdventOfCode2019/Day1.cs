using System;
using System.IO;

namespace AdventOfCode2019
{
    public class Day1 : ISolution
    {
        private string _inputLocation;
        public Day1(string inputLocation)
        {
            _inputLocation = inputLocation;
        }

        public void RunPart2()
        {
            IFuelCalculator fuelCalc = new FuelCalculator();
            string[] inputContent = File.ReadAllLines(_inputLocation);
            int totalFuel = 0;
            foreach (string line in inputContent)
            {
                totalFuel += fuelCalc.FuelForModule(int.Parse(line));
            }
            Console.WriteLine($"Fuel required: {totalFuel} ");
        }

        public void RunPart1()
        {
            IFuelCalculator fuelCalc = new FuelCalculator();
            string[] inputContent = File.ReadAllLines(_inputLocation);

            int newTotalFuel = 0;
            int totalFuel = 0;

            foreach (string line in inputContent)
            {
                newTotalFuel += fuelCalc.FuelForModuleAndFuel(int.Parse(line));
            }
            Console.WriteLine($"Fuel required: {newTotalFuel}");

            Console.WriteLine($"Difference is: {newTotalFuel - totalFuel}");
        }
    }
}