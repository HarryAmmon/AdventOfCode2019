using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution Day1 = new Day1();

            Day1.Part1("../inputs/Day1.txt");
            Day1.Part2("../inputs/Day1.txt");
        }
    }
}
