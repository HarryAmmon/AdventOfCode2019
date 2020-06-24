namespace AdventOfCode2019
{
    public class FuelCalculator : IFuelCalculator
    {
        public int FuelForModule(int moduleMass) => (moduleMass / 3) - 2;

        public int FuelForModuleAndFuel(int moduleMass)
        {
            var requiredFuel = FuelForModule(moduleMass);
            if (requiredFuel > 0)
            {
                return requiredFuel + FuelForModuleAndFuel(requiredFuel);
            }
            else
            {
                return 0;
            }


        }
    }
}