using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            IFuelCalculator fuelCalc = new FuelCalculator();
            string[] inputContent = File.ReadAllLines("../inputs/Day1.txt");
            int totalFuel = 0;
            foreach (string line in inputContent)
            {
                totalFuel += fuelCalc.FuelForModule(int.Parse(line));
            }
            Console.WriteLine($"Fuel required: {totalFuel} ");

            int newTotalFuel = 0;
            foreach (string line in inputContent)
            {
                newTotalFuel += fuelCalc.FuelForModuleAndFuel(int.Parse(line));
            }
            Console.WriteLine($"Fuel required: {newTotalFuel}");

            Console.WriteLine($"Difference is: {newTotalFuel - totalFuel}");
        }
    }
}
