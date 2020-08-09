namespace AdventOfCode2019.Entities
{
    public class Vector
    {
        public readonly string Direction;
        public readonly int Magnitude;
        public Vector(string direction, int magnitude)
        {
            Direction = direction;
            Magnitude = magnitude;
        }
    }
}