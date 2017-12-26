using System;

namespace PlaidTowel
{
    class PlaidTowel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char signA = char.Parse(Console.ReadLine());
            char signB = char.Parse(Console.ReadLine());

            string lineA = new string(signA, n) + signB + new string(signA, n * 2 - 1) + signB + new string(signA, n);
            Console.WriteLine(lineA);

            for (int i = 0; i < n - 1; i++)
            {
                string lineB = new string(signA, n - i - 1) + signB + new string(signA, 1 + 2 * i) + signB + new string(signA, n * 2 - 3 - 2 * i)
                    + signB + new string(signA, 1 + 2 * i) + signB + new string(signA, n - i - 1);
                Console.WriteLine(lineB);
            }

            string lineC = signB + new string(signA, n * 2 - 1) + signB + new string(signA, n * 2 - 1) + signB;
            Console.WriteLine(lineC);

            for (int i = 0; i < n - 1; i++)
            {
                string lineB = new string(signA, i + 1) + signB + new string(signA, n * 2 - 3 - 2 * i) + signB + new string(signA, 1 + 2 * i)
                    + signB + new string(signA, n * 2 - 3 - 2 * i) + signB + new string(signA, i + 1);
                Console.WriteLine(lineB);
            }

            Console.WriteLine(lineA);

            for (int i = 0; i < n - 1; i++)
            {
                string lineB = new string(signA, n - i - 1) + signB + new string(signA, 1 + 2 * i) + signB + new string(signA, n * 2 - 3 - 2 * i)
                    + signB + new string(signA, 1 + 2 * i) + signB + new string(signA, n - i - 1);
                Console.WriteLine(lineB);
            }
            
            Console.WriteLine(lineC);

            for (int i = 0; i < n - 1; i++)
            {
                string lineB = new string(signA, i + 1) + signB + new string(signA, n * 2 - 3 - 2 * i) + signB + new string(signA, 1 + 2 * i)
                    + signB + new string(signA, n * 2 - 3 - 2 * i) + signB + new string(signA, i + 1);
                Console.WriteLine(lineB);
            }

            Console.WriteLine(lineA);
        }
    }
}
