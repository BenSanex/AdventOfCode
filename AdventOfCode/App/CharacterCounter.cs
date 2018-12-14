using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    public class CharacterCounter
    {
        public CharacterCounter() { }
        public Dictionary<char, int> CountCharacters(string input)
        {
            
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var character in input)
            {
                if (!counts.TryAdd(character, 1))
                {
                    counts[character] += 1;
                }
            }

            return counts;
        }

        public bool HasDouble(Dictionary<char, int> input)
        {
            return input.Values.Contains(2);
        }

        public bool HasTriplet(Dictionary<char, int> input)
        {
            return input.Values.Contains(3);
        }
    }

    public class Counts
    {
        public int Doubles { get; set; }
        public int Triples { get; set; }
    }


}
