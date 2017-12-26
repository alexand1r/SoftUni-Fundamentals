using System;

namespace MagicWand
{
    class MagicWand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3 + 2;

            string symbols = new string('.', (width / 2)) + "*" + new string('.', (width / 2));
            Console.WriteLine(symbols);

            for (int i = 1; i <= n / 2 + 1; i++)
            {
                symbols = new string('.', (width / 2) - i) + "*" + new string('.', (i * 2) - 1) + "*" + new string('.', (width / 2) - i);
                Console.WriteLine(symbols);
            }

            symbols = new string('*', n) + new string('.', width - (n * 2)) + new string('*', n);
            Console.WriteLine(symbols);

            for (int i = 1; i <= n / 2; i++)
            {
                symbols = new string('.', i) + "*" + new string('.', (width - (2 * i)) - 2) + "*" + new string('.', i);
                Console.WriteLine(symbols);
            }

            for (int i = 1; i <= n / 2; i++)
            {
                symbols = new string('.', (n / 2) - i) + "*" + new string('.', n / 2) + "*" +new string('.', i - 1) 
                    + "*" + new string('.', n) + "*" + new string('.', i - 1) + "*" + new string('.', n / 2) + "*" 
                    + new string('.', (n / 2) - i);
                Console.WriteLine(symbols);
            }

            symbols = new string('*', (n / 2) + 1) + new string('.', n / 2) + "*" + new string('.', n) + "*" + new string('.', n / 2) + new string('*', (n / 2) + 1);
            Console.WriteLine(symbols);

            for (int i = 0; i < n; i++)
            {
                symbols = new string('.', n) + "*" + new string('.', n) + "*" + new string('.', n);
                Console.WriteLine(symbols);
            }

            symbols = new string('.', n) + new string('*', n + 2) + new string('.', n);
            Console.WriteLine(symbols);
        }
    }
}
