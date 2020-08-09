using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution solution = new Day3("../inputs/Day3.txt");

            solution.RunPart1();
            // solution.RunPart2();
        }
    }
}
