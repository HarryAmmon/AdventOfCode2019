using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution solution = new Day2("../inputs/Day2.txt");

            solution.RunPart1();
            solution.RunPart2();
        }
    }
}
