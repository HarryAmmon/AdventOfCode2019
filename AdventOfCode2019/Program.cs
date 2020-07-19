using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution solution = new Day2();

            solution.Part1("../inputs/Day2.txt");
            solution.Part2("../inputs/Day2.txt");
        }
    }
}
