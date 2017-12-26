using System;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(Search))
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (i + endIndex + 1 > text.Length - 1)
                    {
                        endIndex = Math.Abs(text.Length - 1 - i - jump);
                    }

                    string matchedString = text.Substring(i, endIndex + 1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
