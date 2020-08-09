using System.Text.RegularExpressions;
using AdventOfCode2019.Entities;

namespace AdventOfCode2019
{
    public class InstructionDecoder : IInstructionDecoder
    {
        public Vector VectorDecoder(string instruction)
        {
            string directionPattern = @"([URDL])";
            string magnitudePattern = @"([0-9]+)";

            Match directionResult = Regex.Match(instruction, directionPattern);
            Match magnitudeResult = Regex.Match(instruction, magnitudePattern);

            if (directionResult.Success && magnitudeResult.Success)
            {
                return new Vector(directionResult.Value, int.Parse(magnitudeResult.Value));
            }
            else { return new Vector("", 0); }
        }

        public Vector[] VectorDecoder(string[] instructions)
        {
            Vector[] vectors = new Vector[instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                vectors[i] = VectorDecoder(instructions[i]);
            }
            return vectors;
        }
    }
}