using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public interface IWireThreader
    {
        Coordinate ThreadX(int vector);
        Coordinate ThreadY(int vector);
        Vector Decode(string instruction);
    }
}