using System;
using System.Collections.Generic;

namespace _12.CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();
            IDictionary<string, int> letters =
                     new SortedDictionary<string, int>();
            foreach (string item in name)
            {
                if (string.IsNullOrEmpty(item.Trim()))
                {
                    continue;
                }
                int count;
                if (!letters.TryGetValue(item, out count))
                {
                    count = 0;
                }
                letters[item] = count + 1;
            }
            foreach (KeyValuePair<string, int> letterEntry
                      in letters)
            {
                Console.WriteLine(
                      "{0} -> {1}",
                      letterEntry.Key, letterEntry.Value);
            }
        }
    }
}
