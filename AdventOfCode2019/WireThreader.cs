using System;
using System.Text.RegularExpressions;
using AdventOfCode2019;
using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public class WireThreader : IWireThreader
    {
        private Wire _wire;

        public WireThreader(Wire wire)
        {
            _wire = wire;
        }

        public Coordinate Thread(Vector[] vectors)
        {
            foreach (Vector vector in vectors)
            {
                Thread(vector);
            }
            return _wire.currentPosition;
        }

        public Coordinate Thread(Vector vector)
        {
            switch (vector.Direction)
            {
                case "L":
                    return ThreadXNegative(vector.Magnitude);
                case "R":
                    return ThreadXPositive(vector.Magnitude);
                case "U":
                    return ThreadYPositive(vector.Magnitude);
                case "D":
                    return ThreadYNegative(vector.Magnitude);
                default:
                    throw new Exception("Invalid vector");
            }
        }

        public Coordinate ThreadXNegative(int vector)
        {
            for (int i = 0; i < Math.Abs(vector); i++)
            {
                RecordCurrentPosition();
                _wire.currentPosition.x -= 1;
            }

            return _wire.currentPosition;
        }

        public Coordinate ThreadXPositive(int vector)
        {
            for (int i = 0; i < vector; i++)
            {
                RecordCurrentPosition();
                _wire.currentPosition.x += 1;
            }
            return _wire.currentPosition;
        }

        public Coordinate ThreadYNegative(int vector)
        {
            for (int i = 0; i < Math.Abs(vector); i++)
            {
                RecordCurrentPosition();
                _wire.currentPosition.y -= 1;
            }

            return _wire.currentPosition;
        }

        public Coordinate ThreadYPositive(int vector)
        {
            for (int i = 0; i < vector; i++)
            {
                RecordCurrentPosition();
                _wire.currentPosition.y += 1;
            }
            return _wire.currentPosition;
        }

        private void RecordCurrentPosition()
        {
            Coordinate currentPosition = new Coordinate(_wire.currentPosition.x, _wire.currentPosition.y);
            _wire.previousPositions.Add(currentPosition);
        }
    }
}