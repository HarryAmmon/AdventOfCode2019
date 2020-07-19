using System;
using System.IO;

namespace AdventOfCode2019
{
    public class Day2 : ISolution
    {
        public void Part1(string inputLocation)
        {
            int[] programCode = GetIntArrayFromInput(inputLocation);

            IIntCodeComputer computer = new IntCodeComputer(programCode);
            var result = computer.RunProgramCode(12, 2);

            Console.WriteLine($"Program result: {result}");
        }

        public void Part2(string inputLocation)
        {
            int[] programCode = GetIntArrayFromInput(inputLocation);

            IIntCodeComputer computer = new IntCodeComputer(programCode);
            for (int noun = 1; noun < 99; noun++)
            {
                for (int verb = 1; verb < 99; verb++)
                {
                    computer.ResetProgramCode();
                    int result = computer.RunProgramCode(noun, verb);
                    if (result == 19690720)
                    {
                        Console.WriteLine($"Program result: {100 * noun + verb}");
                        Console.WriteLine($"Noun: {noun}");
                        Console.WriteLine($"Verb: {verb}");
                        break;
                    }
                }
            }
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