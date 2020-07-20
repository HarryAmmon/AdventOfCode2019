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