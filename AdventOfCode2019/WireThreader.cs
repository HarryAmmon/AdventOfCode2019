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
    }
}