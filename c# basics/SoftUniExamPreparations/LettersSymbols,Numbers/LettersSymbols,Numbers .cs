using System;
using System.Text.RegularExpressions;

namespace LettersSymbols_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int letterCount = 0;
            int numberCount = 0;
            int symbolCount = 0;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine().ToLower();
                text = Regex.Replace(text, "\\s+", "");

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] >= 'a' && text[j] <= 'z')
                    {
                        letterCount += (text[j] - 96) * 10;
                    }
                    else if (text[j] >= '0' && text[j] <= '9')
                    {
                        numberCount += (text[j] - 48) * 20;
                    }
                    else
                    {
                        symbolCount += 200;
                    }
                }
            }

            Console.WriteLine("{0}\n{1}\n{2}", letterCount, numberCount, symbolCount);
        }
    }
}
