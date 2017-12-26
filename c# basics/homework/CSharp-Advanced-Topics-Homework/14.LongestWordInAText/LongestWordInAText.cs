using System;
using System.Collections.Generic;

namespace _14.LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string[] text = Console.ReadLine().Split();
            for (int i = 0; i < text.Length; i++)
            {
                list.Add(text[i]);
            }

            string longest = string.Empty;
            foreach (var item in list)
            {
                if (item.Length > longest.Length)
                {
                    longest = item;
                }
            }

            string result = string.Empty;
            if (longest.Contains("."))
            {
                result = longest.Replace(".", string.Empty);
            }
            else result = longest;

            Console.WriteLine(result);
        }
    }
}
