using System;

namespace FilledSquare
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n, '-');

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n, '-');
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write("-");

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }

            Console.Write("-");
            Console.WriteLine();
        }

        private static void PrintHeaderRow(int n, char ch)
        {
            Console.WriteLine(new string(ch, 2 * n));
        }
    }
}
