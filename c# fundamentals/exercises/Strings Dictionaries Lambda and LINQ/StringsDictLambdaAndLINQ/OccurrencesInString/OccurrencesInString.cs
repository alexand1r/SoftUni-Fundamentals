﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesInString
{
    class OccurrencesInString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0, offset = -1;
            while (true)
            {
                offset = text.IndexOf(word, offset + 1);
                if (offset == -1) break; // No more occurrences
                count++;
            }
            Console.WriteLine($"{count}");
        }
    }
}
