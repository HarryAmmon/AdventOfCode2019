namespace AdventOfCode2019
{
    public class FuelCalculator : IFuelCalculator
    {
        public int FuelForModule(int moduleMass) => (moduleMass / 3) - 2;
    }
}