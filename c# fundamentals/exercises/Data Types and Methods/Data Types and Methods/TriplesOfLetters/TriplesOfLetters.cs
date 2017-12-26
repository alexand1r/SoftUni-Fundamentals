using System;

namespace TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
            {
                char letter1 = (char)('a' + i);
                for (int j = 0; j <= n - 1; j++)
                {
                    char letter2 = (char)('a' + j);
                    for (int k = 0; k <= n - 1; k++)
                    {
                        char letter3 = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}
