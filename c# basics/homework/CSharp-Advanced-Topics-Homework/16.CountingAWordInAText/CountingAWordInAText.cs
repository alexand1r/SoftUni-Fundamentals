using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _16.CountingAWordInAText
{
    class CountingAWordInAText
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            int count = WordCount(word, text);
            Console.WriteLine(count);
        }

        private static int WordCount(string word, string text)
        {
            var regex = new Regex(string.Format(@"\b{0}\b", word),
                              RegexOptions.IgnoreCase);
            return regex.Matches(text).Count;
        }
    }
}
