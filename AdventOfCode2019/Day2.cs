using System;
using System.IO;

namespace AdventOfCode2019
{
    public class Day2 : ISolution
    {
        public void Part1(string inputLocation)
        {
            int[] programCode = GetIntArrayFromInput(inputLocation);
            programCode[1] = 12;
            programCode[2] = 2;

            IIntCodeComputer computer = new IntCodeComputer(programCode);
            var result = computer.RunProgramCode();

            Console.WriteLine($"Program result: {result[0]}");
        }

        public void Part2(string inputLocation)
        {
            throw new System.NotImplementedException();
        }

        private int[] GetIntArrayFromInput(string inputLocation)
        {

            string[] inputFile = File.ReadAllLines(inputLocation);
            string[] stringProgramCode = inputFile[0].Split(',');
            int[] programCode = new int[stringProgramCode.Length];
            for (int i = 0; i < stringProgramCode.Length; i++)
            {
                programCode[i] = int.Parse(stringProgramCode[i]);
            }
            return programCode;
        }
    }
}