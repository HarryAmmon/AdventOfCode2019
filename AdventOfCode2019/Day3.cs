using System;
using System.IO;
using AdventOfCode2019.Entities;

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
            Wire wire1 = new Wire();
            Wire wire2 = new Wire();
        }

        public void RunPart2()
        {
            throw new System.NotImplementedException();
        }
    }
}