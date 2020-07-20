using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventOfCode2019
{
    public class Day3 : ISolution
    {
        private string[] _fileInput;
        public Day3(string inputLocation)
        {
            _fileInput = File.ReadAllLines(inputLocation);
        }

        public void RunPart1()
        {
            string[] wireOneInstructions = _fileInput[0].Split(',');
            string[] wireTwoInstructions = _fileInput[1].Split(',');
            string pattern = @"([RULD])";

            foreach (string item in wireOneInstructions)
            {
                string[] instruction = Regex.Split(item, pattern);
                foreach (string i in instruction)
                {
                    Console.WriteLine(i);
                }
            }
            // Wire wire2 = new Wire();
        }

        public void RunPart2()
        {
            throw new System.NotImplementedException();
        }
    }
}