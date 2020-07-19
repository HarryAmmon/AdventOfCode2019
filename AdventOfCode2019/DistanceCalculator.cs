using System;
using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public class DistanceCalculator : IDistanceCalculator
    {
        public int CalculateManhattenDistance(Coordinate poisition1, Coordinate position2)
        {
            return Math.Abs(poisition1.x - position2.x) + Math.Abs(poisition1.y - position2.y);
        }
    }
}