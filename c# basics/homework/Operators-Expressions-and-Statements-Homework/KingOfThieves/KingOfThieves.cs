using System;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            string line = String.Empty;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                line = new string('-', n / 2 - i) + new string(type, 2 * i + 1) + new string('-', n / 2 - i);
                Console.WriteLine(line);
            }
            for (int i = n / 2; i > 0; i--)
            {
                line = new string('-', n / 2 - i + 1) + new string(type, 2 * i - 1) + new string('-', n / 2 - i + 1);
                Console.WriteLine(line);
            }
        }
    }
}
