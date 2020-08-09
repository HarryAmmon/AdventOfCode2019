using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public interface IWireThreader
    {
        Coordinate ThreadXPositive(int vector);
        Coordinate ThreadXNegative(int vector);
        Coordinate ThreadYPositive(int vector);
        Coordinate ThreadYNegative(int vector);
        Coordinate Thread(Vector vector);
        Coordinate Thread(Vector[] vectors);
    }
}