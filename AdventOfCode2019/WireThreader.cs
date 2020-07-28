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

        public Vector Decode(string instruction)
        {
            string directionPattern = @"([URDL])";
            string magnitudePattern = @"([0-9]+)";

            Match directionResult = Regex.Match(instruction, directionPattern);
            Match magnitudeResult = Regex.Match(instruction, magnitudePattern);

            if (directionResult.Success && magnitudeResult.Success)
            {
                return new Vector(directionResult.Value, int.Parse(magnitudeResult.Value));
            }
            return null;
        }

        public Coordinate ThreadX(int vector)
        {
            RecordCurrentPosition();

            _wire.currentPosition.x += vector;
            return _wire.currentPosition;
        }

        public Coordinate ThreadY(int vector)
        {
            RecordCurrentPosition();

            _wire.currentPosition.y += vector;
            return _wire.currentPosition;
        }

        private void RecordCurrentPosition()
        {
            _wire.previousPositions.Add(_wire.currentPosition);
        }
    }
}