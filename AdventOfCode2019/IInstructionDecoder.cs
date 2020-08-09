using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public interface IInstructionDecoder
    {
        Vector VectorDecoder(string instruction);

        Vector[] VectorDecoder(string[] instructions);
    }
}