using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\Ben\Downloads\thing.txt";
            char[] result;

            int counter = 0;
            List<int> cumulativeTotals = new List<int> {counter};
            using (StreamReader reader = File.OpenText(filename))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    int num = 0;
                    int.TryParse(line, out num);
                    counter += num;
                    if (cumulativeTotals.Contains(counter))
                    {
                        Console.WriteLine(counter);
                        Console.ReadLine();
                        return;
                    }

                    cumulativeTotals.Add(counter);
                    if (reader.EndOfStream)
                    {
                        reader.DiscardBufferedData();
                        reader.BaseStream.Seek(0, SeekOrigin.Begin);
                    }
                }
            }

            Console.WriteLine(counter);
            Console.ReadLine();
        }

    }
    
}
