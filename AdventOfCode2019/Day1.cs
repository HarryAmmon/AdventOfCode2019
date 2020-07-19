using System;
using System.IO;

namespace AdventOfCode2019
{
    public class Day1 : ISolution
    {
        public void Part2(string inputLocation)
        {
            IFuelCalculator fuelCalc = new FuelCalculator();
            string[] inputContent = File.ReadAllLines(inputLocation);
            int totalFuel = 0;
            foreach (string line in inputContent)
            {
                totalFuel += fuelCalc.FuelForModule(int.Parse(line));
            }
            Console.WriteLine($"Fuel required: {totalFuel} ");
        }

        public void Part1(string inputLocation)
        {
            IFuelCalculator fuelCalc = new FuelCalculator();
            string[] inputContent = File.ReadAllLines(inputLocation);

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