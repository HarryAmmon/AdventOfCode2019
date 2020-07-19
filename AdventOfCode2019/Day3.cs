using System;
using System.IO;

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
            Console.WriteLine(10 - 20);
        }

        public void RunPart2()
        {
            throw new System.NotImplementedException();
        }
    }
}