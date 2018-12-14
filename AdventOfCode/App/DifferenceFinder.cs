using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    public class DifferenceFinder
    {
        public List<string> FindStringsWithOneDifference(List<string> input)
        {
            var allOptions = new List<string>();
            foreach (var item in input)
            {
                foreach (var innerItem in input)
                    {
                        var sb = new StringBuilder();
                        for (var index=0;index < item.Length; index++)
                        {
                            if (item[index] == innerItem[index])
                            {
                                sb.Append(item[index]);
                            }
                        }
                        if (sb.Length == item.Length - 1)
                            allOptions.Add(sb.ToString());

                        sb.Clear();
                    };
            }

            return allOptions.Distinct().ToList();
        }

    }
}
