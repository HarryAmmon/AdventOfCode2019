using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
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
            Wire wireOne = new Wire(0, 0);
            Wire wireTwo = new Wire(0, 0);

            WireThreader threaderOne = new WireThreader(wireOne);
            WireThreader threaderTwo = new WireThreader(wireTwo);

            InstructionDecoder decoder = new InstructionDecoder();

            string[] wireOneInstructions = _fileInput[0].Split(',');
            string[] wireTwoInstructions = _fileInput[1].Split(',');

            Vector[] vectors1 = decoder.VectorDecoder(wireOneInstructions);
            Vector[] vectors2 = decoder.VectorDecoder(wireTwoInstructions);

            DistanceCalculator calc = new DistanceCalculator();

            threaderOne.Thread(vectors1);
            threaderTwo.Thread(vectors2);

            int count = 0;
            int currentShortestDistance = int.MaxValue;
            foreach (Coordinate coord in wireOne.previousPositions)
            {
                foreach (Coordinate location in wireTwo.previousPositions)
                {
                    if (coord.x == location.x && coord.y == location.y)
                    {
                        Console.WriteLine("MATCH");
                        Console.WriteLine($"Coord: {coord.toString()}");
                        Console.WriteLine($"Location: {location.toString()}");

                        int distance = calc.CalculateManhattenDistance(coord, new Coordinate(0, 0));
                        if (distance != 0 && distance < currentShortestDistance)
                        {
                            currentShortestDistance = distance;
                        }
                    }
                }
            }
            Console.WriteLine($"Shortest Distance: {currentShortestDistance}");
        }

        public void RunPart2()
        {
            throw new System.NotImplementedException();
        }
    }
}