using System;

namespace Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string line = new string('.', (n * 3) / 2) + "*" + new string('.', (n * 3) / 2);
            Console.WriteLine(line);

            for (int i = 0; i < n - 1; i++) {
                string line2 = new string('.', i + 1) + "*" + new string('.', (n * 3 - (3 + 2 * (i + 1))) / 2)
                    + "*" + new string('.', (n * 3 - (3 + 2 * (i + 1))) / 2) + "*" + new string('.', i + 1);
                Console.WriteLine(line2);
            }

            for (int i = 0; i < n / 2; i++)
            {
                string line3 = new string('.', n) + new string('*', n) + new string('.', n);
                Console.WriteLine(line3);
            }

            string middle = new string('*', n * 3);
            Console.WriteLine(middle);

            for (int i = 0; i < n / 2; i++)
            {
                string line4 = new string('.', n) + new string('*', n) + new string('.', n);
                Console.WriteLine(line4);
            }

            for (int i = n; i > 1; i--)
            {
                string line5 = new string('.', i - 1) + "*" + new string('.', (n * 3 - (3 + 2 * (i - 1))) / 2)
                    + "*" + new string('.', (n * 3 - (3 + 2 * (i - 1))) / 2) + "*" + new string('.', i - 1);
                Console.WriteLine(line5);
            }

            Console.WriteLine(line);
        }
    }
}
