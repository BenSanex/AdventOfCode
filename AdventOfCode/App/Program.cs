using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace App
{
    class Program
    {
        private static readonly CharacterCounter _counter = new CharacterCounter();
        static void Main(string[] args)
        {
            string filename = @"F:\Repos\AdventOfCode\AdventOfCode\Input.txt";
            
            var totals = new Counts {Doubles = 0, Triples = 0};
            
            using (StreamReader reader = File.OpenText(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var counts = _counter.CountCharacters(line);
                    if (_counter.HasDouble(counts))
                        totals.Doubles ++;
                    if (_counter.HasTriplet(counts))
                        totals.Triples ++;
                }
            }

            Console.WriteLine($"{totals.Doubles} with 2, {totals.Triples} with 3, {totals.Doubles * totals.Triples} checksum");
            Console.ReadLine();
        }
    }
}
