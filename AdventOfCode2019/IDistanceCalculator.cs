using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public interface IDistanceCalculator
    {
        int CalculateManhattenDistance(Coordinate poisition1, Coordinate position2);
    }
}