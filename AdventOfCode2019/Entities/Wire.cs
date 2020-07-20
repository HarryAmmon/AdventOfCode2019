using System.Collections.Generic;

namespace AdventOfCode2019.Entities
{
    public class Wire
    {
        public List<Coordinate> previousPositions = new List<Coordinate>();
        public Coordinate currentPosition;
        public Wire(int StartX, int StartY)
        {
            currentPosition = new Coordinate(StartX, StartY);
        }
    }
}