using System;

namespace SummertimeForProgrammers
{
    class SummertimeForProgrammers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bottomWidth = 2 * n;
            int topWidth = n + 1;

            string line = new string(' ', n / 2) + new string('*', topWidth) + new string(' ', n / 2);
            Console.WriteLine(line);

            for (int i = 0; i < n / 2; i++)
            {
                line = new string(' ', n / 2) + "*" + new string(' ', n - 1) + "*" + new string(' ', n / 2);
                Console.WriteLine(line);
            }

            for (int i = 0; i < n / 2; i++)
            {
                line = new string(' ', n / 2 - i) + "*" + new string(' ', n - 1 + 2 * i) + "*" + new string(' ', n / 2 - i);
                Console.WriteLine(line);
            }

            for (int i = 0; i < n; i++)
            {
                line = "*" + new string('.', bottomWidth - 2) + "*";
                Console.WriteLine(line);
            }

            for (int i = 0; i < n; i++)
            {
                line = "*" + new string('@', bottomWidth - 2) + "*";
                Console.WriteLine(line);
            }

            line = new string('*', bottomWidth);
            Console.WriteLine(line);
        }
    }
}
