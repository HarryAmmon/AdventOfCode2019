using AdventOfCode2019;
using AdventOfCode2019.Entities;
using Xunit;

namespace AdventOfCode2019Tests
{
    public class WireThreaderTest
    {
        private Wire _wire;
        public WireThreaderTest()
        {
            _wire = new Wire();
        }

        [Fact]
        public void Can_Thread_Wire_Positive_X_Direction()
        {
            // Arrange
            IWireThreader wireThreader = new WireThreader(_wire);

            // Act

        }
    }
}