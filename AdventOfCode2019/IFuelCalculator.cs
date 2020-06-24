namespace AdventOfCode2019
{
    public interface IFuelCalculator
    {
        int FuelForModule(int moduleMass);

        int FuelForModuleAndFuel(int moduleMass);
    }
}